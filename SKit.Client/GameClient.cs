﻿using SKit.Lib;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace SKit.Client
{
    public class GameClient
    {
        private TcpClient _tcpClient;
        private NetworkStream _stream;
        private byte[] _buffer = new byte[1024];
        private int _cursor;
        private ISPackager _packager;

        public GameClient(ISPackager packager)
        {
            _packager = packager;
        }

        public void Start(string ip, int port)
        {
            _tcpClient = new TcpClient();
            _tcpClient.Connect(ip, port);

            _stream = _tcpClient.GetStream();
            var result = _stream.BeginRead(_buffer, 0, _buffer.Length, OnRead, _stream);
        }

        public void Stop()
        {
            CloseSocket();
        }

        public void Send(Object msg)
        {
            var body = Encoding.UTF8.GetBytes((String)msg);
            var data = _packager.Pack(body, 0, body.Length);
            _stream.Write(data.Array, data.Offset, data.Count);
        }

        /// <summary>
        /// 拆包
        /// </summary>
        private IEnumerable<ArraySegment<byte>> Resolve(int size)
        {
            int from = 0;
            _cursor += size;//剩余可读取字节

            while (true)
            {
                var readlength = 0;
                ArraySegment<byte> data = _packager.UnPack(_buffer, from, _cursor, ref readlength);
                if (readlength != 0)
                {
                    yield return data;
                    _cursor -= readlength;
                    from += readlength;
                    continue;
                }
                break;
            }
            if (_cursor > 0)
            {
                Buffer.BlockCopy(_buffer, from, _buffer, 0, _cursor);
            }
            //e.SetBuffer(_cursor, _buffer.Length - _cursor);
        }

        private void OnRead(IAsyncResult ar)
        {
            NetworkStream stream = (NetworkStream)ar.AsyncState;
            var size = stream.EndRead(ar);

            // check if the remote host closed the connection
            if (size > 0)
            {
                var datas = Resolve(size);
                foreach (ArraySegment<byte> data in datas)
                {
                    OnMessageReceiving(data);
                }
                
                stream.BeginRead(_buffer, _cursor, _buffer.Length - _cursor, OnRead, stream);
                //PostReceive(receiveEventArgs);
            }
            else
            {
                CloseSocket();
            }
        }

        private void OnMessageReceiving(ArraySegment<byte> data)
        {
            string msg = Encoding.UTF8.GetString(data.Array, data.Offset, data.Count);
            Console.WriteLine("收到消息: " + msg);
        }

        private void CloseSocket()
        {
            _stream.Close();
            _tcpClient.Close();
        }
    }
}

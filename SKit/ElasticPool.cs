﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SKit
{
    public class ElasticPool<T>
    {
        private Stack<T> _pool;
        private Func<T> _builder;

        public ElasticPool(Func<T> builder)
        {
            _pool = new Stack<T>();
            _builder = builder;
        }

        public T Pop()
        {
            if (_pool.Count == 0)
            {
                return _builder.Invoke();
            }
            return _pool.Pop();
        }

        public void Push(T element)
        {
            _pool.Push(element);
        }
    }
}

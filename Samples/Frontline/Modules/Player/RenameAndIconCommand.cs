﻿using Frontline.Common;
using Frontline.Data;
using Frontline.Domain;
using Newtonsoft.Json.Linq;
using protocol;
using SKit;
using SKit.Common;
using SKit.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Frontline.Modules
{
    public class RenameAndIconCommand : GameCommand<RenameAndIconRequest>
    {
        PlayerModule _playerModule;
        DataContext _db;
        GameServerSettings _config;

        protected override void OnInit()
        {
            _playerModule = Server.GetModule<PlayerModule>();
            _db = Server.GetModule<GameSettingModule>().DataContext;
            _config = Server.GetModule<GameSettingModule>().Settings;
        }

        public override int ExecuteCommand()
        {
            RenameAndIconResponse r = new RenameAndIconResponse();
            r.success = true;
            r.nickyName = Request.nickyName;
            r.icon = Request.icon;
            //todo: 判断和谐字
            if(Request.icon == null)
            {
                if (Request.nickyName == null || Request.nickyName.Length <= 2 || Request.nickyName.Length >= 20)
                {
                    return (int)GameErrorCode.名字长度不符合规则;
                }
                bool dup = _db.Players.Any(p => p.NickName == Request.nickyName);
                if (dup)
                {
                    return (int)GameErrorCode.名字已被使用;
                }
                var player = _playerModule.QueryPlayer(Session.PlayerId);
                
                if (Request.nickyName != player.NickName)
                {
                    int[] costs = GameConfig.RenameCostDiamond;
                    int cost = costs[costs.Length - 1];
                    if (player.RenameNumb < costs.Length)
                    {
                        cost = costs[player.RenameNumb];
                    }

                    if (player.Wallet.DIAMOND < cost)
                    {
                        return (int)GameErrorCode.资源不足;
                    }
                    player.NickName = Request.nickyName;
                    player.RenameNumb++;
                    _db.SaveChanges();
                    Session.SendAsync(r);
                }
            }
            else
            {
                var player = _playerModule.QueryPlayer(Session.PlayerId);
                if (Request.icon != player.Icon)
                {
                    player.Icon = Request.icon;
                    _db.SaveChanges();
                }
            }
            Session.SendAsync(r);
            return 0;
        }
    }
}
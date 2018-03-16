﻿using Newtonsoft.Json;
using protocol;
using SKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontline.GameControllers
{
    public class RankListController : GameController
    {
        public void RankingListInfo(GetRankingListRequest request)
        {
            GetRankingListResponse response = JsonConvert.DeserializeObject<GetRankingListResponse>("{ \"myRank\":0,\"type\":2,\"rankInfos\":[],\"success\":true}");
            CurrentSession.SendAsync(response);
        }
    }
}
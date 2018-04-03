using ProtoBuf;
using System.Collections.Generic;
using System;

namespace protocol
{
    /// <summary>
    /// 升级军团科技 协议:368
    /// </summary>
	[Proto(value=368,description="升级军团科技")]
	[ProtoContract]
	public class LegionScienceLevelUpRequest
    {
        /// <summary>
        ///  科技Id
        /// </summary>
		[ProtoMember(1, IsRequired = false)]
		public int scienceId;
	}
}
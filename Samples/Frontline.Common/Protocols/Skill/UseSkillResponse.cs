//using ProtoBuf;
//using System.Collections.Generic;
//using System;

//namespace protocol
//{
//    /// <summary>
//    /// 使用技能 协议:-30
//    /// </summary>
//	[Proto(value=-30,description="使用技能")]
//	[ProtoContract]
//	public class UseSkillResponse
//	{
//        /// <summary>
//        ///  id
//        /// </summary>
//		[ProtoMember(3, IsRequired = false)]
//		public int sid;
//        /// <summary>
//        ///  是否成功
//        /// </summary>
//		[ProtoMember(1, IsRequired = false)]
//		public bool success;
//        /// <summary>
//        ///  错误码
//        /// </summary>
//		[ProtoMember(2, IsRequired = false)]
//		public string info;

//	}
//}
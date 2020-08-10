using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api;

namespace DingTalk.Api.Response
{
    /// <summary>
    /// OapiRobotMessageOrggrouptaskQueryResponse.
    /// </summary>
    public class OapiRobotMessageOrggrouptaskQueryResponse : DingTalkResponse
    {
        /// <summary>
        /// 错误代码
        /// </summary>
        [XmlElement("errcode")]
        public long Errcode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("errmsg")]
        public string Errmsg { get; set; }

        /// <summary>
        /// result
        /// </summary>
        [XmlElement("result")]
        public GroupMessageTaskQueryTopResponseDomain Result { get; set; }

        /// <summary>
        /// 是否受理成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

	/// <summary>
/// GroupMessageTaskQueryTopResponseDomain Data Structure.
/// </summary>
[Serializable]

public class GroupMessageTaskQueryTopResponseDomain : TopObject
{
	        /// <summary>
	        /// 发送结果码，只有SUCCESS为成功
	        /// </summary>
	        [XmlElement("send_status")]
	        public string SendStatus { get; set; }
}

    }
}

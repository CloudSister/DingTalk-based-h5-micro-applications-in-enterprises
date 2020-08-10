using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Util;
using Top.Api;
using Top.Api.DingTalk;

namespace DingTalk.Api.Request
{
    /// <summary>
    /// TOP API: dingtalk.oapi.blackboard.create
    /// </summary>
    public class OapiBlackboardCreateRequest : BaseDingTalkRequest<DingTalk.Api.Response.OapiBlackboardCreateResponse>
    {
        /// <summary>
        /// 请求入参
        /// </summary>
        public string CreateRequest { get; set; }

        public OapiCreateBlackboardVoDomain CreateRequest_ { set { this.CreateRequest = TopUtils.ObjectToJson(value); } } 

        #region IDingTalkRequest Members

        public override string GetApiName()
        {
            return "dingtalk.oapi.blackboard.create";
        }

        public override string GetApiCallType()
        {
            return DingTalkConstants.CALL_TYPE_OAPI;
        }

        public override IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("create_request", this.CreateRequest);
            if (this.otherParams != null)
            {
                parameters.AddAll(this.otherParams);
            }
            return parameters;
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("create_request", this.CreateRequest);
        }

	/// <summary>
/// BlackboardReceiverOpenVoDomain Data Structure.
/// </summary>
[Serializable]

public class BlackboardReceiverOpenVoDomain : TopObject
{
	        /// <summary>
	        /// 接收部门id列表
	        /// </summary>
	        [XmlArray("deptid_list")]
	        [XmlArrayItem("number")]
	        public List<string> DeptidList { get; set; }
	
	        /// <summary>
	        /// 接收人userId列表
	        /// </summary>
	        [XmlArray("userid_list")]
	        [XmlArrayItem("string")]
	        public List<string> UseridList { get; set; }
}

	/// <summary>
/// OapiCreateBlackboardVoDomain Data Structure.
/// </summary>
[Serializable]

public class OapiCreateBlackboardVoDomain : TopObject
{
	        /// <summary>
	        /// 公告作者
	        /// </summary>
	        [XmlElement("author")]
	        public string Author { get; set; }
	
	        /// <summary>
	        /// 入参
	        /// </summary>
	        [XmlElement("blackboard_receiver")]
	        public BlackboardReceiverOpenVoDomain BlackboardReceiver { get; set; }
	
	        /// <summary>
	        /// 公告分类id，可以通过https://oapi.dingtalk.com/blackboard/category/get获取有效值
	        /// </summary>
	        [XmlElement("category_id")]
	        public string CategoryId { get; set; }
	
	        /// <summary>
	        /// 公告内容
	        /// </summary>
	        [XmlElement("content")]
	        public string Content { get; set; }
	
	        /// <summary>
	        /// 封面图,需要使用mediaId,可以通过https://oapi.dingtalk.com/media/upload上传图片获取mediaId
	        /// </summary>
	        [XmlElement("coverpic_mediaid")]
	        public string CoverpicMediaid { get; set; }
	
	        /// <summary>
	        /// 是否发送应用内钉提醒
	        /// </summary>
	        [XmlElement("ding")]
	        public Nullable<bool> Ding { get; set; }
	
	        /// <summary>
	        /// 操作人的userId(必须是公告管理员)
	        /// </summary>
	        [XmlElement("operation_userid")]
	        public string OperationUserid { get; set; }
	
	        /// <summary>
	        /// 保密等级，仅支持以下值(0:普通公告，20：保密公告)
	        /// </summary>
	        [XmlElement("private_level")]
	        public Nullable<long> PrivateLevel { get; set; }
	
	        /// <summary>
	        /// 公告是否置顶
	        /// </summary>
	        [XmlElement("push_top")]
	        public Nullable<bool> PushTop { get; set; }
	
	        /// <summary>
	        /// 公告标题
	        /// </summary>
	        [XmlElement("title")]
	        public string Title { get; set; }
}

        #endregion
    }
}

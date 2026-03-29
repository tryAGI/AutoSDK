//HintName: G.Models.OpenAPIStreamResumeFlowResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIStreamResumeFlowResponse
    {
        /// <summary>
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// ContentType为Text时的返回
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// DEPRECATED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        public string? Cost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public global::G.ResponseDetail? Detail { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 事件类型:message,done,error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        public string? Event { get; set; }

        /// <summary>
        /// 成功时最后一条消息
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ext")]
        public global::System.Collections.Generic.Dictionary<string, string>? Ext { get; set; }

        /// <summary>
        /// 绝对序号
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupt_data")]
        public global::G.Interrupt? InterruptData { get; set; }

        /// <summary>
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。<br/>
        /// 状态码为 0 时，msg 默认为空。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? Msg { get; set; }

        /// <summary>
        /// 节点是否执行完成
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_is_finish")]
        public bool? NodeIsFinish { get; set; }

        /// <summary>
        /// 节点信息节点中的序号
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_seq_id")]
        public string? NodeSeqId { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_title")]
        public string? NodeTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.Usage1? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIStreamResumeFlowResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </param>
        /// <param name="content">
        /// ContentType为Text时的返回
        /// </param>
        /// <param name="cost">
        /// DEPRECATED
        /// </param>
        /// <param name="detail"></param>
        /// <param name="errorCode">
        /// 错误信息
        /// </param>
        /// <param name="errorMessage"></param>
        /// <param name="event">
        /// 事件类型:message,done,error
        /// </param>
        /// <param name="ext">
        /// 成功时最后一条消息
        /// </param>
        /// <param name="id">
        /// 绝对序号
        /// </param>
        /// <param name="interruptData"></param>
        /// <param name="msg">
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。<br/>
        /// 状态码为 0 时，msg 默认为空。
        /// </param>
        /// <param name="nodeIsFinish">
        /// 节点是否执行完成
        /// </param>
        /// <param name="nodeSeqId">
        /// 节点信息节点中的序号
        /// </param>
        /// <param name="nodeTitle">
        /// 节点名称
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPIStreamResumeFlowResponse(
            int? code,
            string? content,
            string? cost,
            global::G.ResponseDetail? detail,
            int? errorCode,
            string? errorMessage,
            string? @event,
            global::System.Collections.Generic.Dictionary<string, string>? ext,
            string? id,
            global::G.Interrupt? interruptData,
            string? msg,
            bool? nodeIsFinish,
            string? nodeSeqId,
            string? nodeTitle,
            global::G.Usage1? usage)
        {
            this.Code = code;
            this.Content = content;
            this.Cost = cost;
            this.Detail = detail;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.Event = @event;
            this.Ext = ext;
            this.Id = id;
            this.InterruptData = interruptData;
            this.Msg = msg;
            this.NodeIsFinish = nodeIsFinish;
            this.NodeSeqId = nodeSeqId;
            this.NodeTitle = nodeTitle;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIStreamResumeFlowResponse" /> class.
        /// </summary>
        public OpenAPIStreamResumeFlowResponse()
        {
        }
    }
}
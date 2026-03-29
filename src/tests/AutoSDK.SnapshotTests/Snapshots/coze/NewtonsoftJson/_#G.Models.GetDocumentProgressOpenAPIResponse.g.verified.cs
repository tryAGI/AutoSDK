//HintName: G.Models.GetDocumentProgressOpenAPIResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDocumentProgressOpenAPIResponse
    {
        /// <summary>
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public int Code { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.GetDocumentProgressOpenAPIResponseData? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.GetDocumentProgressOpenAPIResponseDetail? Detail { get; set; }

        /// <summary>
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。<br/>
        /// 状态码为 0 时，msg 默认为空。
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msg")]
        public string? Msg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentProgressOpenAPIResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </param>
        /// <param name="data"></param>
        /// <param name="detail"></param>
        /// <param name="msg">
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。<br/>
        /// 状态码为 0 时，msg 默认为空。
        /// </param>
        public GetDocumentProgressOpenAPIResponse(
            int code,
            global::G.GetDocumentProgressOpenAPIResponseData? data,
            global::G.GetDocumentProgressOpenAPIResponseDetail? detail,
            string? msg)
        {
            this.Code = code;
            this.Data = data;
            this.Detail = detail;
            this.Msg = msg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentProgressOpenAPIResponse" /> class.
        /// </summary>
        public GetDocumentProgressOpenAPIResponse()
        {
        }
    }
}
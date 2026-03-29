//HintName: G.Models.CreateDocumentOpenAPIResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDocumentOpenAPIResponse
    {
        /// <summary>
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public int? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.ResponseDetail? Detail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_infos")]
        public global::System.Collections.Generic.IList<global::G.DocumentInfo>? DocumentInfos { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateDocumentOpenAPIResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </param>
        /// <param name="detail"></param>
        /// <param name="documentInfos"></param>
        /// <param name="msg">
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。<br/>
        /// 状态码为 0 时，msg 默认为空。
        /// </param>
        public CreateDocumentOpenAPIResponse(
            int? code,
            global::G.ResponseDetail? detail,
            global::System.Collections.Generic.IList<global::G.DocumentInfo>? documentInfos,
            string? msg)
        {
            this.Code = code;
            this.Detail = detail;
            this.DocumentInfos = documentInfos;
            this.Msg = msg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentOpenAPIResponse" /> class.
        /// </summary>
        public CreateDocumentOpenAPIResponse()
        {
        }
    }
}
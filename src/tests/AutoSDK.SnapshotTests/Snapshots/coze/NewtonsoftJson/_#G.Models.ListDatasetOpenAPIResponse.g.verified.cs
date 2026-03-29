//HintName: G.Models.ListDatasetOpenAPIResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListDatasetOpenAPIResponse
    {
        /// <summary>
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public int? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.ListDatasetOpenApiData? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.ResponseDetail? Detail { get; set; }

        /// <summary>
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msg")]
        public string? Msg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDatasetOpenAPIResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </param>
        /// <param name="data"></param>
        /// <param name="detail"></param>
        /// <param name="msg">
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。
        /// </param>
        public ListDatasetOpenAPIResponse(
            int? code,
            global::G.ListDatasetOpenApiData? data,
            global::G.ResponseDetail? detail,
            string? msg)
        {
            this.Code = code;
            this.Data = data;
            this.Detail = detail;
            this.Msg = msg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDatasetOpenAPIResponse" /> class.
        /// </summary>
        public ListDatasetOpenAPIResponse()
        {
        }
    }
}
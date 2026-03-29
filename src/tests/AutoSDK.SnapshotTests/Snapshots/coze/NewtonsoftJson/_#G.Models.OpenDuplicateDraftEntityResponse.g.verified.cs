//HintName: G.Models.OpenDuplicateDraftEntityResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenDuplicateDraftEntityResponse
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
        public global::G.OpenDuplicateDraftEntityData? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.ResponseDetail? Detail { get; set; }

        /// <summary>
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msg", Required = global::Newtonsoft.Json.Required.Always)]
        public string Msg { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenDuplicateDraftEntityResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </param>
        /// <param name="msg">
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。
        /// </param>
        /// <param name="data"></param>
        /// <param name="detail"></param>
        public OpenDuplicateDraftEntityResponse(
            int code,
            string msg,
            global::G.OpenDuplicateDraftEntityData? data,
            global::G.ResponseDetail? detail)
        {
            this.Code = code;
            this.Data = data;
            this.Detail = detail;
            this.Msg = msg ?? throw new global::System.ArgumentNullException(nameof(msg));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenDuplicateDraftEntityResponse" /> class.
        /// </summary>
        public OpenDuplicateDraftEntityResponse()
        {
        }
    }
}
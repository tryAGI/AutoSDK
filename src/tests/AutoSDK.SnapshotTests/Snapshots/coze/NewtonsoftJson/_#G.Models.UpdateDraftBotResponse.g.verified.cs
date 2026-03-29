//HintName: G.Models.UpdateDraftBotResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDraftBotResponse
    {
        /// <summary>
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public int Code { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.PropertiesDetail? Detail { get; set; }

        /// <summary>
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。<br/>
        /// 状态码为 0 时，msg 默认为空。
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msg", Required = global::Newtonsoft.Json.Required.Always)]
        public string Msg { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDraftBotResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </param>
        /// <param name="msg">
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。<br/>
        /// 状态码为 0 时，msg 默认为空。
        /// </param>
        /// <param name="detail"></param>
        public UpdateDraftBotResponse(
            int code,
            string msg,
            global::G.PropertiesDetail? detail)
        {
            this.Code = code;
            this.Detail = detail;
            this.Msg = msg ?? throw new global::System.ArgumentNullException(nameof(msg));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDraftBotResponse" /> class.
        /// </summary>
        public UpdateDraftBotResponse()
        {
        }
    }
}
//HintName: G.Models.OpenRemoveSpaceMemberResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenRemoveSpaceMemberResponse
    {
        /// <summary>
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::G.OpenRemoveSpaceMemberData? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public global::G.ResponseDetail? Detail { get; set; }

        /// <summary>
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Msg { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRemoveSpaceMemberResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </param>
        /// <param name="msg">
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。
        /// </param>
        /// <param name="data"></param>
        /// <param name="detail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenRemoveSpaceMemberResponse(
            int code,
            string msg,
            global::G.OpenRemoveSpaceMemberData? data,
            global::G.ResponseDetail? detail)
        {
            this.Code = code;
            this.Data = data;
            this.Detail = detail;
            this.Msg = msg ?? throw new global::System.ArgumentNullException(nameof(msg));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenRemoveSpaceMemberResponse" /> class.
        /// </summary>
        public OpenRemoveSpaceMemberResponse()
        {
        }
    }
}
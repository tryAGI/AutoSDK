//HintName: G.Models.OpenAPIRunFlowResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIRunFlowResponse
    {
        /// <summary>
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Code { get; set; }

        /// <summary>
        /// 同步返回字段工作流执行结果 (JSON 序列化字符串或普通字符串)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// 工作流试运行调试页面 URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug_url")]
        public string? DebugUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public global::G.PropertiesDetail? Detail { get; set; }

        /// <summary>
        /// 异步返回字段异步执行的事件 ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execute_id")]
        public string? ExecuteId { get; set; }

        /// <summary>
        /// content type为interrupt时传输，中断协议
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupt_data")]
        public global::G.PropertiesInterruptData? InterruptData { get; set; }

        /// <summary>
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。<br/>
        /// 状态码为 0 时，msg 默认为空。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? Msg { get; set; }

        /// <summary>
        /// 资源使用情况
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::G.PropertiesUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIRunFlowResponse" /> class.
        /// </summary>
        /// <param name="code">
        /// 调用状态码。0 表示调用成功，其他值表示调用失败，你可以通过 msg 字段判断详细的错误原因。
        /// </param>
        /// <param name="data">
        /// 同步返回字段工作流执行结果 (JSON 序列化字符串或普通字符串)
        /// </param>
        /// <param name="debugUrl">
        /// 工作流试运行调试页面 URL
        /// </param>
        /// <param name="detail"></param>
        /// <param name="executeId">
        /// 异步返回字段异步执行的事件 ID
        /// </param>
        /// <param name="interruptData">
        /// content type为interrupt时传输，中断协议
        /// </param>
        /// <param name="msg">
        /// 状态信息。API 调用失败时可通过此字段查看详细错误信息。<br/>
        /// 状态码为 0 时，msg 默认为空。
        /// </param>
        /// <param name="usage">
        /// 资源使用情况
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPIRunFlowResponse(
            int code,
            string? data,
            string? debugUrl,
            global::G.PropertiesDetail? detail,
            string? executeId,
            global::G.PropertiesInterruptData? interruptData,
            string? msg,
            global::G.PropertiesUsage? usage)
        {
            this.Code = code;
            this.Data = data;
            this.DebugUrl = debugUrl;
            this.Detail = detail;
            this.ExecuteId = executeId;
            this.InterruptData = interruptData;
            this.Msg = msg;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIRunFlowResponse" /> class.
        /// </summary>
        public OpenAPIRunFlowResponse()
        {
        }
    }
}
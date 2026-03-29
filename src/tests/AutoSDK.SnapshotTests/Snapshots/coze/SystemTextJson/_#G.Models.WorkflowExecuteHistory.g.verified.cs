//HintName: G.Models.WorkflowExecuteHistory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowExecuteHistory
    {
        /// <summary>
        /// 执行工作流时指定的 Bot ID。返回 0 表示未指定智能体 ID。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_id")]
        public string? BotId { get; set; }

        /// <summary>
        /// 智能体的发布渠道 ID，默认仅显示 Agent as API 渠道，渠道 ID 为 1024。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        public string? ConnectorId { get; set; }

        /// <summary>
        /// 用户 ID，执行工作流时通过 ext 字段指定的 user_id。如果未指定，则返回 Token 申请人的扣子 ID。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_uid")]
        public string? ConnectorUid { get; set; }

        /// <summary>
        /// 工作流运行开始时间，Unixtime 时间戳格式，单位为秒。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 工作流试运行调试页面。访问此页面可查看每个工作流节点的运行结果、输入输出等信息。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug_url")]
        public string? DebugUrl { get; set; }

        /// <summary>
        /// 执行失败调用状态码。0 表示调用成功。其他值表示调用失败。你可以通过 error_message 字段判断详细的错误原因。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string? ErrorCode { get; set; }

        /// <summary>
        /// 状态信息。为 API 调用失败时可通过此字段查看详细错误信息。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 执行 ID。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execute_id")]
        public string? ExecuteId { get; set; }

        /// <summary>
        /// 执行状态。Success：执行成功。Running：执行中。Fail：执行失败。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execute_status")]
        public string? ExecuteStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interrupt_data")]
        public global::G.Interrupt? InterruptData { get; set; }

        /// <summary>
        /// 工作流的输出是否因为过大被清理。true：已清理。false：未清理。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_output_trimmed")]
        public bool? IsOutputTrimmed { get; set; }

        /// <summary>
        /// 工作流异步运行的 Log ID。如果工作流执行异常，可以联系服务团队通过 Log ID 排查问题。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logid")]
        public string? Logid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_execute_status")]
        public global::System.Collections.Generic.Dictionary<string, global::G.NodeExecuteStatus>? NodeExecuteStatus { get; set; }

        /// <summary>
        /// 工作流的输出，通常为 JSON 序列化字符串，也有可能是非 JSON 结构的字符串。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public string? Output { get; set; }

        /// <summary>
        /// 工作流的运行方式：0：同步运行。1：流式运行。2：异步运行。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_mode")]
        public int? RunMode { get; set; }

        /// <summary>
        /// 工作流的恢复运行时间，Unixtime 时间戳格式，单位为秒。
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update_time")]
        public int? UpdateTime { get; set; }

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
        /// Initializes a new instance of the <see cref="WorkflowExecuteHistory" /> class.
        /// </summary>
        /// <param name="botId">
        /// 执行工作流时指定的 Bot ID。返回 0 表示未指定智能体 ID。
        /// </param>
        /// <param name="connectorId">
        /// 智能体的发布渠道 ID，默认仅显示 Agent as API 渠道，渠道 ID 为 1024。
        /// </param>
        /// <param name="connectorUid">
        /// 用户 ID，执行工作流时通过 ext 字段指定的 user_id。如果未指定，则返回 Token 申请人的扣子 ID。
        /// </param>
        /// <param name="createTime">
        /// 工作流运行开始时间，Unixtime 时间戳格式，单位为秒。
        /// </param>
        /// <param name="debugUrl">
        /// 工作流试运行调试页面。访问此页面可查看每个工作流节点的运行结果、输入输出等信息。
        /// </param>
        /// <param name="errorCode">
        /// 执行失败调用状态码。0 表示调用成功。其他值表示调用失败。你可以通过 error_message 字段判断详细的错误原因。
        /// </param>
        /// <param name="errorMessage">
        /// 状态信息。为 API 调用失败时可通过此字段查看详细错误信息。
        /// </param>
        /// <param name="executeId">
        /// 执行 ID。
        /// </param>
        /// <param name="executeStatus">
        /// 执行状态。Success：执行成功。Running：执行中。Fail：执行失败。
        /// </param>
        /// <param name="interruptData"></param>
        /// <param name="isOutputTrimmed">
        /// 工作流的输出是否因为过大被清理。true：已清理。false：未清理。
        /// </param>
        /// <param name="logid">
        /// 工作流异步运行的 Log ID。如果工作流执行异常，可以联系服务团队通过 Log ID 排查问题。
        /// </param>
        /// <param name="nodeExecuteStatus"></param>
        /// <param name="output">
        /// 工作流的输出，通常为 JSON 序列化字符串，也有可能是非 JSON 结构的字符串。
        /// </param>
        /// <param name="runMode">
        /// 工作流的运行方式：0：同步运行。1：流式运行。2：异步运行。
        /// </param>
        /// <param name="updateTime">
        /// 工作流的恢复运行时间，Unixtime 时间戳格式，单位为秒。
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowExecuteHistory(
            string? botId,
            string? connectorId,
            string? connectorUid,
            int? createTime,
            string? debugUrl,
            string? errorCode,
            string? errorMessage,
            string? executeId,
            string? executeStatus,
            global::G.Interrupt? interruptData,
            bool? isOutputTrimmed,
            string? logid,
            global::System.Collections.Generic.Dictionary<string, global::G.NodeExecuteStatus>? nodeExecuteStatus,
            string? output,
            int? runMode,
            int? updateTime,
            global::G.Usage1? usage)
        {
            this.BotId = botId;
            this.ConnectorId = connectorId;
            this.ConnectorUid = connectorUid;
            this.CreateTime = createTime;
            this.DebugUrl = debugUrl;
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.ExecuteId = executeId;
            this.ExecuteStatus = executeStatus;
            this.InterruptData = interruptData;
            this.IsOutputTrimmed = isOutputTrimmed;
            this.Logid = logid;
            this.NodeExecuteStatus = nodeExecuteStatus;
            this.Output = output;
            this.RunMode = runMode;
            this.UpdateTime = updateTime;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecuteHistory" /> class.
        /// </summary>
        public WorkflowExecuteHistory()
        {
        }
    }
}
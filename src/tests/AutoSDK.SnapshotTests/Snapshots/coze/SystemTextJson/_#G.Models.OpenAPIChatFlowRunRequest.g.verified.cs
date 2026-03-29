//HintName: G.Models.OpenAPIChatFlowRunRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIChatFlowRunRequest
    {
        /// <summary>
        /// required 对话中用户问题和历史消息
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EnterMessage> AdditionalMessages { get; set; }

        /// <summary>
        /// 需要关联的扣子应用 ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 需要关联的智能体 ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_id")]
        public string? BotId { get; set; }

        /// <summary>
        /// 渠道ID，比如ui builder、template、商店等
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        public string? ConnectorId { get; set; }

        /// <summary>
        /// 对话流对应的会话 ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// 用于指定一些额外的字段，例如经纬度、用户ID等
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ext")]
        public global::System.Collections.Generic.Dictionary<string, string>? Ext { get; set; }

        /// <summary>
        /// required 设置对话流输入参数中的自定义参数 (map[String]any)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Parameters { get; set; }

        /// <summary>
        /// required 待执行的对话流 ID，此对话流应已发布
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowId { get; set; }

        /// <summary>
        /// 资源库工作流版本，只有运行工作流为资源库内工作流时可以传值，不传默认使用最新版本
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_version")]
        public string? WorkflowVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIChatFlowRunRequest" /> class.
        /// </summary>
        /// <param name="additionalMessages">
        /// required 对话中用户问题和历史消息
        /// </param>
        /// <param name="parameters">
        /// required 设置对话流输入参数中的自定义参数 (map[String]any)
        /// </param>
        /// <param name="workflowId">
        /// required 待执行的对话流 ID，此对话流应已发布
        /// </param>
        /// <param name="appId">
        /// 需要关联的扣子应用 ID
        /// </param>
        /// <param name="botId">
        /// 需要关联的智能体 ID
        /// </param>
        /// <param name="connectorId">
        /// 渠道ID，比如ui builder、template、商店等
        /// </param>
        /// <param name="conversationId">
        /// 对话流对应的会话 ID
        /// </param>
        /// <param name="ext">
        /// 用于指定一些额外的字段，例如经纬度、用户ID等
        /// </param>
        /// <param name="workflowVersion">
        /// 资源库工作流版本，只有运行工作流为资源库内工作流时可以传值，不传默认使用最新版本
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OpenAPIChatFlowRunRequest(
            global::System.Collections.Generic.IList<global::G.EnterMessage> additionalMessages,
            object parameters,
            string workflowId,
            string? appId,
            string? botId,
            string? connectorId,
            string? conversationId,
            global::System.Collections.Generic.Dictionary<string, string>? ext,
            string? workflowVersion)
        {
            this.AdditionalMessages = additionalMessages ?? throw new global::System.ArgumentNullException(nameof(additionalMessages));
            this.AppId = appId;
            this.BotId = botId;
            this.ConnectorId = connectorId;
            this.ConversationId = conversationId;
            this.Ext = ext;
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
            this.WorkflowVersion = workflowVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIChatFlowRunRequest" /> class.
        /// </summary>
        public OpenAPIChatFlowRunRequest()
        {
        }
    }
}
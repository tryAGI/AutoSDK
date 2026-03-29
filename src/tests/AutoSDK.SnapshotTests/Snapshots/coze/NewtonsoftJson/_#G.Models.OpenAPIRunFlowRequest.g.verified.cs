//HintName: G.Models.OpenAPIRunFlowRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIRunFlowRequest
    {
        /// <summary>
        /// 该工作流关联的应用的 ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 需要关联的智能体 ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bot_id")]
        public string? BotId { get; set; }

        /// <summary>
        /// 渠道 ID，比如 ui builder、template、商店等
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connector_id")]
        public string? ConnectorId { get; set; }

        /// <summary>
        /// 用于指定一些额外的字段，非必要可不填写
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ext")]
        public global::System.Collections.Generic.Dictionary<string, string>? Ext { get; set; }

        /// <summary>
        /// 是否异步运行 (默认 false)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_async")]
        public bool? IsAsync { get; set; }

        /// <summary>
        /// 工作流开始节点的输入参数及取值 (JSON 序列化字符串)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// required, 待执行的 Workflow ID，此工作流应已发布
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkflowId { get; set; } = default!;

        /// <summary>
        /// 资源库工作流版本，只有运行工作流为资源库内工作流时可以传值，不传默认使用最新版本
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workflow_version")]
        public string? WorkflowVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIRunFlowRequest" /> class.
        /// </summary>
        /// <param name="workflowId">
        /// required, 待执行的 Workflow ID，此工作流应已发布
        /// </param>
        /// <param name="appId">
        /// 该工作流关联的应用的 ID
        /// </param>
        /// <param name="botId">
        /// 需要关联的智能体 ID
        /// </param>
        /// <param name="connectorId">
        /// 渠道 ID，比如 ui builder、template、商店等
        /// </param>
        /// <param name="ext">
        /// 用于指定一些额外的字段，非必要可不填写
        /// </param>
        /// <param name="isAsync">
        /// 是否异步运行 (默认 false)
        /// </param>
        /// <param name="parameters">
        /// 工作流开始节点的输入参数及取值 (JSON 序列化字符串)
        /// </param>
        /// <param name="workflowVersion">
        /// 资源库工作流版本，只有运行工作流为资源库内工作流时可以传值，不传默认使用最新版本
        /// </param>
        public OpenAPIRunFlowRequest(
            string workflowId,
            string? appId,
            string? botId,
            string? connectorId,
            global::System.Collections.Generic.Dictionary<string, string>? ext,
            bool? isAsync,
            object? parameters,
            string? workflowVersion)
        {
            this.AppId = appId;
            this.BotId = botId;
            this.ConnectorId = connectorId;
            this.Ext = ext;
            this.IsAsync = isAsync;
            this.Parameters = parameters;
            this.WorkflowId = workflowId ?? throw new global::System.ArgumentNullException(nameof(workflowId));
            this.WorkflowVersion = workflowVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIRunFlowRequest" /> class.
        /// </summary>
        public OpenAPIRunFlowRequest()
        {
        }
    }
}
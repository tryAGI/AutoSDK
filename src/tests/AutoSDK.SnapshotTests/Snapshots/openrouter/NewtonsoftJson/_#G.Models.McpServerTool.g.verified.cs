//HintName: G.Models.McpServerTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MCP (Model Context Protocol) tool configuration
    /// </summary>
    public sealed partial class McpServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.McpServerToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_label", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServerLabel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_tools")]
        public global::G.McpServerToolAllowedTools? AllowedTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authorization")]
        public string? Authorization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("connector_id")]
        public global::G.McpServerToolConnectorId? ConnectorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("require_approval")]
        public global::G.McpServerToolRequireApproval? RequireApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_description")]
        public string? ServerDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("server_url")]
        public string? ServerUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerTool" /> class.
        /// </summary>
        /// <param name="serverLabel"></param>
        /// <param name="type"></param>
        /// <param name="allowedTools"></param>
        /// <param name="authorization"></param>
        /// <param name="connectorId"></param>
        /// <param name="headers"></param>
        /// <param name="requireApproval"></param>
        /// <param name="serverDescription"></param>
        /// <param name="serverUrl"></param>
        public McpServerTool(
            string serverLabel,
            global::G.McpServerToolType type,
            global::G.McpServerToolAllowedTools? allowedTools,
            string? authorization,
            global::G.McpServerToolConnectorId? connectorId,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::G.McpServerToolRequireApproval? requireApproval,
            string? serverDescription,
            string? serverUrl)
        {
            this.Type = type;
            this.ServerLabel = serverLabel ?? throw new global::System.ArgumentNullException(nameof(serverLabel));
            this.AllowedTools = allowedTools;
            this.Authorization = authorization;
            this.ConnectorId = connectorId;
            this.Headers = headers;
            this.RequireApproval = requireApproval;
            this.ServerDescription = serverDescription;
            this.ServerUrl = serverUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerTool" /> class.
        /// </summary>
        public McpServerTool()
        {
        }
    }
}
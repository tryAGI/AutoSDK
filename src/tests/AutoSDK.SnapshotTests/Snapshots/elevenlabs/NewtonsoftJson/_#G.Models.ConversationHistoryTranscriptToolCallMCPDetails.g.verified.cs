//HintName: G.Models.ConversationHistoryTranscriptToolCallMCPDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptToolCallMCPDetails
    {
        /// <summary>
        /// Default Value: mcp
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_server_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpServerId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_server_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpServerName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integration_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string IntegrationType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::System.Collections.Generic.Dictionary<string, string>? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approval_policy", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApprovalPolicy { get; set; } = default!;

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requires_approval")]
        public bool? RequiresApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_tool_name")]
        public string? McpToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mcp_tool_description")]
        public string? McpToolDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallMCPDetails" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: mcp
        /// </param>
        /// <param name="mcpServerId"></param>
        /// <param name="mcpServerName"></param>
        /// <param name="integrationType"></param>
        /// <param name="parameters"></param>
        /// <param name="approvalPolicy"></param>
        /// <param name="requiresApproval">
        /// Default Value: false
        /// </param>
        /// <param name="mcpToolName"></param>
        /// <param name="mcpToolDescription"></param>
        public ConversationHistoryTranscriptToolCallMCPDetails(
            string mcpServerId,
            string mcpServerName,
            string integrationType,
            string approvalPolicy,
            string? type,
            global::System.Collections.Generic.Dictionary<string, string>? parameters,
            bool? requiresApproval,
            string? mcpToolName,
            string? mcpToolDescription)
        {
            this.McpServerId = mcpServerId ?? throw new global::System.ArgumentNullException(nameof(mcpServerId));
            this.McpServerName = mcpServerName ?? throw new global::System.ArgumentNullException(nameof(mcpServerName));
            this.IntegrationType = integrationType ?? throw new global::System.ArgumentNullException(nameof(integrationType));
            this.ApprovalPolicy = approvalPolicy ?? throw new global::System.ArgumentNullException(nameof(approvalPolicy));
            this.Type = type;
            this.Parameters = parameters;
            this.RequiresApproval = requiresApproval;
            this.McpToolName = mcpToolName;
            this.McpToolDescription = mcpToolDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallMCPDetails" /> class.
        /// </summary>
        public ConversationHistoryTranscriptToolCallMCPDetails()
        {
        }
    }
}
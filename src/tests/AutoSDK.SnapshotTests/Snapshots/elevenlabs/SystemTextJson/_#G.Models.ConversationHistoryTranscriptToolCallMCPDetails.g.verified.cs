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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.Dictionary<string, string>? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval_policy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApprovalPolicy { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requires_approval")]
        public bool? RequiresApproval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_tool_name")]
        public string? McpToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_tool_description")]
        public string? McpToolDescription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptToolCallMCPDetails" /> class.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="mcpServerName"></param>
        /// <param name="integrationType"></param>
        /// <param name="approvalPolicy"></param>
        /// <param name="type">
        /// Default Value: mcp
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="requiresApproval">
        /// Default Value: false
        /// </param>
        /// <param name="mcpToolName"></param>
        /// <param name="mcpToolDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
            this.Type = type;
            this.McpServerId = mcpServerId ?? throw new global::System.ArgumentNullException(nameof(mcpServerId));
            this.McpServerName = mcpServerName ?? throw new global::System.ArgumentNullException(nameof(mcpServerName));
            this.IntegrationType = integrationType ?? throw new global::System.ArgumentNullException(nameof(integrationType));
            this.Parameters = parameters;
            this.ApprovalPolicy = approvalPolicy ?? throw new global::System.ArgumentNullException(nameof(approvalPolicy));
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
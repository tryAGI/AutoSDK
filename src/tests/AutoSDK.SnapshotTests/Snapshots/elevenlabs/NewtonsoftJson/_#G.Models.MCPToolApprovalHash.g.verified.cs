//HintName: G.Models.MCPToolApprovalHash.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model for storing tool approval hashes for per-tool approval.
    /// </summary>
    public sealed partial class MCPToolApprovalHash
    {
        /// <summary>
        /// The name of the MCP tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolName { get; set; } = default!;

        /// <summary>
        /// SHA256 hash of the tool's parameters and description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_hash", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToolHash { get; set; } = default!;

        /// <summary>
        /// Defines the tool-level approval policy.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approval_policy")]
        public global::G.MCPToolApprovalPolicy? ApprovalPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolApprovalHash" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The name of the MCP tool
        /// </param>
        /// <param name="toolHash">
        /// SHA256 hash of the tool's parameters and description
        /// </param>
        /// <param name="approvalPolicy">
        /// Defines the tool-level approval policy.
        /// </param>
        public MCPToolApprovalHash(
            string toolName,
            string toolHash,
            global::G.MCPToolApprovalPolicy? approvalPolicy)
        {
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolHash = toolHash ?? throw new global::System.ArgumentNullException(nameof(toolHash));
            this.ApprovalPolicy = approvalPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolApprovalHash" /> class.
        /// </summary>
        public MCPToolApprovalHash()
        {
        }
    }
}
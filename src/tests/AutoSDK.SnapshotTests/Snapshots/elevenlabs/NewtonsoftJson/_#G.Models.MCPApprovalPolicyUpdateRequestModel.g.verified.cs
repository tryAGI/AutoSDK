//HintName: G.Models.MCPApprovalPolicyUpdateRequestModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request model for updating MCP Server approval mode.
    /// </summary>
    public sealed partial class MCPApprovalPolicyUpdateRequestModel
    {
        /// <summary>
        /// Defines the MCP server-level approval policy for tool execution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("approval_policy", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MCPApprovalPolicy ApprovalPolicy { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApprovalPolicyUpdateRequestModel" /> class.
        /// </summary>
        /// <param name="approvalPolicy">
        /// Defines the MCP server-level approval policy for tool execution.
        /// </param>
        public MCPApprovalPolicyUpdateRequestModel(
            global::G.MCPApprovalPolicy approvalPolicy)
        {
            this.ApprovalPolicy = approvalPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPApprovalPolicyUpdateRequestModel" /> class.
        /// </summary>
        public MCPApprovalPolicyUpdateRequestModel()
        {
        }
    }
}
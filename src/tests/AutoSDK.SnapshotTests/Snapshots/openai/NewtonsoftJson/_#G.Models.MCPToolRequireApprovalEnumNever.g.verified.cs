//HintName: G.Models.MCPToolRequireApprovalEnumNever.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of tools that never require approval.
    /// </summary>
    public sealed partial class MCPToolRequireApprovalEnumNever
    {
        /// <summary>
        /// List of tools that do not require approval.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_names")]
        public global::System.Collections.Generic.IList<string>? ToolNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolRequireApprovalEnumNever" /> class.
        /// </summary>
        /// <param name="toolNames">
        /// List of tools that do not require approval.
        /// </param>
        public MCPToolRequireApprovalEnumNever(
            global::System.Collections.Generic.IList<string>? toolNames)
        {
            this.ToolNames = toolNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolRequireApprovalEnumNever" /> class.
        /// </summary>
        public MCPToolRequireApprovalEnumNever()
        {
        }
    }
}
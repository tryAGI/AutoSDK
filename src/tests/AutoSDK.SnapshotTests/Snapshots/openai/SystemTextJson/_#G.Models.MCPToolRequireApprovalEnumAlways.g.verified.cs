//HintName: G.Models.MCPToolRequireApprovalEnumAlways.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A list of tools that always require approval.
    /// </summary>
    public sealed partial class MCPToolRequireApprovalEnumAlways
    {
        /// <summary>
        /// List of tools that require approval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_names")]
        public global::System.Collections.Generic.IList<string>? ToolNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolRequireApprovalEnumAlways" /> class.
        /// </summary>
        /// <param name="toolNames">
        /// List of tools that require approval.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MCPToolRequireApprovalEnumAlways(
            global::System.Collections.Generic.IList<string>? toolNames)
        {
            this.ToolNames = toolNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolRequireApprovalEnumAlways" /> class.
        /// </summary>
        public MCPToolRequireApprovalEnumAlways()
        {
        }
    }
}
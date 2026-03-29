//HintName: G.Models.McpServerToolRequireApprovalOneOf0Never.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServerToolRequireApprovalOneOf0Never
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_names")]
        public global::System.Collections.Generic.IList<string>? ToolNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolRequireApprovalOneOf0Never" /> class.
        /// </summary>
        /// <param name="toolNames"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpServerToolRequireApprovalOneOf0Never(
            global::System.Collections.Generic.IList<string>? toolNames)
        {
            this.ToolNames = toolNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolRequireApprovalOneOf0Never" /> class.
        /// </summary>
        public McpServerToolRequireApprovalOneOf0Never()
        {
        }
    }
}
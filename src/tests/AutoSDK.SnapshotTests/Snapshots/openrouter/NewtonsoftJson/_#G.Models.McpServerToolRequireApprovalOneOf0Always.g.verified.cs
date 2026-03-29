//HintName: G.Models.McpServerToolRequireApprovalOneOf0Always.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServerToolRequireApprovalOneOf0Always
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_names")]
        public global::System.Collections.Generic.IList<string>? ToolNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolRequireApprovalOneOf0Always" /> class.
        /// </summary>
        /// <param name="toolNames"></param>
        public McpServerToolRequireApprovalOneOf0Always(
            global::System.Collections.Generic.IList<string>? toolNames)
        {
            this.ToolNames = toolNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolRequireApprovalOneOf0Always" /> class.
        /// </summary>
        public McpServerToolRequireApprovalOneOf0Always()
        {
        }
    }
}
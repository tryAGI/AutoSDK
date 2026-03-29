//HintName: G.Models.McpServerToolAllowedTools1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServerToolAllowedTools1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_names")]
        public global::System.Collections.Generic.IList<string>? ToolNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolAllowedTools1" /> class.
        /// </summary>
        /// <param name="toolNames"></param>
        /// <param name="readOnly"></param>
        public McpServerToolAllowedTools1(
            global::System.Collections.Generic.IList<string>? toolNames,
            bool? readOnly)
        {
            this.ToolNames = toolNames;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerToolAllowedTools1" /> class.
        /// </summary>
        public McpServerToolAllowedTools1()
        {
        }
    }
}
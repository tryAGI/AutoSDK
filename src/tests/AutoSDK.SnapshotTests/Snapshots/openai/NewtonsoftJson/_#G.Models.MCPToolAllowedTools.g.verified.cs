//HintName: G.Models.MCPToolAllowedTools.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A filter object to specify which tools are allowed.
    /// </summary>
    public sealed partial class MCPToolAllowedTools
    {
        /// <summary>
        /// List of allowed tool names.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_names")]
        public global::System.Collections.Generic.IList<string>? ToolNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolAllowedTools" /> class.
        /// </summary>
        /// <param name="toolNames">
        /// List of allowed tool names.
        /// </param>
        public MCPToolAllowedTools(
            global::System.Collections.Generic.IList<string>? toolNames)
        {
            this.ToolNames = toolNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolAllowedTools" /> class.
        /// </summary>
        public MCPToolAllowedTools()
        {
        }
    }
}
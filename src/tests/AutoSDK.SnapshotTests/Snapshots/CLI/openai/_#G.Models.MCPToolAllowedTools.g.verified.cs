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
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_names")]
        public global::System.Collections.Generic.IList<string>? ToolNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MCPToolAllowedTools" /> class.
        /// </summary>
        /// <param name="toolNames">
        /// List of allowed tool names.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
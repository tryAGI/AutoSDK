//HintName: G.Models.ToolsPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsPart
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::G.ToolsPartFunction? Function { get; set; }

        /// <summary>
        /// Example: tool_type
        /// </summary>
        /// <example>tool_type</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsPart" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type">
        /// Example: tool_type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsPart(
            global::G.ToolsPartFunction? function,
            string? type)
        {
            this.Function = function;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsPart" /> class.
        /// </summary>
        public ToolsPart()
        {
        }
    }
}
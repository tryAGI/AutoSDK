//HintName: G.Models.UsedTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsedTool
    {
        /// <summary>
        /// Example: Name of the tool
        /// </summary>
        /// <example>Name of the tool</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        public string? Tool { get; set; }

        /// <summary>
        /// Example: {"input":"search query"}
        /// </summary>
        /// <example>{"input":"search query"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolInput")]
        public global::System.Collections.Generic.Dictionary<string, string>? ToolInput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolOutput")]
        public string? ToolOutput { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsedTool" /> class.
        /// </summary>
        /// <param name="tool">
        /// Example: Name of the tool
        /// </param>
        /// <param name="toolInput">
        /// Example: {"input":"search query"}
        /// </param>
        /// <param name="toolOutput"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsedTool(
            string? tool,
            global::System.Collections.Generic.Dictionary<string, string>? toolInput,
            string? toolOutput)
        {
            this.Tool = tool;
            this.ToolInput = toolInput;
            this.ToolOutput = toolOutput;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsedTool" /> class.
        /// </summary>
        public UsedTool()
        {
        }
    }
}
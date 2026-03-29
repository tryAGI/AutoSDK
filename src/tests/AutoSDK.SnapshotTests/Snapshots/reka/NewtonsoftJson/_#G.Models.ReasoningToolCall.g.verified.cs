//HintName: G.Models.ReasoningToolCall.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An internal tool call made by the Research model.
    /// </summary>
    public sealed partial class ReasoningToolCall
    {
        /// <summary>
        /// The internal tool name (e.g., "search_web", "analyze").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_name")]
        public string? ToolName { get; set; }

        /// <summary>
        /// Arguments passed to the tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments")]
        public object? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningToolCall" /> class.
        /// </summary>
        /// <param name="toolName">
        /// The internal tool name (e.g., "search_web", "analyze").
        /// </param>
        /// <param name="arguments">
        /// Arguments passed to the tool.
        /// </param>
        public ReasoningToolCall(
            string? toolName,
            object? arguments)
        {
            this.ToolName = toolName;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningToolCall" /> class.
        /// </summary>
        public ReasoningToolCall()
        {
        }
    }
}
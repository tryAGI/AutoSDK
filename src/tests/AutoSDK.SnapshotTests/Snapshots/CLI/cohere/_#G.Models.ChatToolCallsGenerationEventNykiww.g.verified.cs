//HintName: G.Models.ChatToolCallsGenerationEventNykiww.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallsGenerationEventNykiww
    {
        /// <summary>
        /// The text generated related to the tool calls generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ToolCall> ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallsGenerationEventNykiww" /> class.
        /// </summary>
        /// <param name="text">
        /// The text generated related to the tool calls generated
        /// </param>
        /// <param name="toolCalls"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatToolCallsGenerationEventNykiww(
            global::System.Collections.Generic.IList<global::G.ToolCall> toolCalls,
            string? text)
        {
            this.ToolCalls = toolCalls ?? throw new global::System.ArgumentNullException(nameof(toolCalls));
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallsGenerationEventNykiww" /> class.
        /// </summary>
        public ChatToolCallsGenerationEventNykiww()
        {
        }
    }
}
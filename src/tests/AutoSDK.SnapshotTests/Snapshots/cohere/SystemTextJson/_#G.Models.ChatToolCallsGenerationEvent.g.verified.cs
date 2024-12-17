//HintName: G.Models.ChatToolCallsGenerationEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallsGenerationEvent : ChatStreamEvent
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
        /// Initializes a new instance of the <see cref="ChatToolCallsGenerationEvent" /> class.
        /// </summary>
        /// <param name="text">
        /// The text generated related to the tool calls generated
        /// </param>
        /// <param name="toolCalls"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatToolCallsGenerationEvent(
            global::System.Collections.Generic.IList<global::G.ToolCall> toolCalls,
            string? text)
        {
            this.ToolCalls = toolCalls ?? throw new global::System.ArgumentNullException(nameof(toolCalls));
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallsGenerationEvent" /> class.
        /// </summary>
        public ChatToolCallsGenerationEvent()
        {
        }
    }
}
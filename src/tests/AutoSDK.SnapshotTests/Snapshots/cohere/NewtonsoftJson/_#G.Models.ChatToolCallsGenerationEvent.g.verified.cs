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
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_calls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ToolCall> ToolCalls { get; set; } = default!;


        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallsGenerationEvent" /> class.
        /// </summary>
        /// <param name="text">
        /// The text generated related to the tool calls generated
        /// </param>
        /// <param name="toolCalls"></param>
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
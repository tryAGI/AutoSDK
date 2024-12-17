//HintName: G.Models.ChatToolCallsChunkEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolCallsChunkEvent : ChatStreamEvent
    {
        /// <summary>
        /// Contains the chunk of the tool call generation in the stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ToolCallDelta ToolCallDelta { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallsChunkEvent" /> class.
        /// </summary>
        /// <param name="toolCallDelta">
        /// Contains the chunk of the tool call generation in the stream.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatToolCallsChunkEvent(
            global::G.ToolCallDelta toolCallDelta)
        {
            this.ToolCallDelta = toolCallDelta ?? throw new global::System.ArgumentNullException(nameof(toolCallDelta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolCallsChunkEvent" /> class.
        /// </summary>
        public ChatToolCallsChunkEvent()
        {
        }
    }
}
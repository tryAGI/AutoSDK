//HintName: G.Models.ChatStreamStartEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatStreamStartEvent : ChatStreamEvent
    {
        /// <summary>
        /// Unique identifier for the generated reply. Useful for submitting feedback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid GenerationId { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamStartEvent" /> class.
        /// </summary>
        /// <param name="generationId">
        /// Unique identifier for the generated reply. Useful for submitting feedback.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ChatStreamStartEvent(
            global::System.Guid generationId)
        {
            this.GenerationId = generationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamStartEvent" /> class.
        /// </summary>
        public ChatStreamStartEvent()
        {
        }
    }
}
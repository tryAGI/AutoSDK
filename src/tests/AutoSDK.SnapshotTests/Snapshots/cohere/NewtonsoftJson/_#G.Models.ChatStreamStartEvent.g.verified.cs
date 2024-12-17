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
        [global::Newtonsoft.Json.JsonProperty("generation_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid GenerationId { get; set; } = default!;


        /// <summary>
        /// Initializes a new instance of the <see cref="ChatStreamStartEvent" /> class.
        /// </summary>
        /// <param name="generationId">
        /// Unique identifier for the generated reply. Useful for submitting feedback.
        /// </param>
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
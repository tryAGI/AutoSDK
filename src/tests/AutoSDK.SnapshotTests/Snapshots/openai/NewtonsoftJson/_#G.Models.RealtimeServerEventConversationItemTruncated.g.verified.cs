//HintName: G.Models.RealtimeServerEventConversationItemTruncated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when an earlier assistant audio message item is truncated by the <br/>
    /// client with a `conversation.item.truncate` event. This event is used to <br/>
    /// synchronize the server's understanding of the audio with the client's playback.<br/>
    /// This action will truncate the audio and remove the server-side text transcript <br/>
    /// to ensure there is no text in the context that hasn't been heard by the user.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationItemTruncated
    {
        /// <summary>
        /// The duration up to which the audio was truncated, in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_end_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int AudioEndMs { get; set; } = default!;

        /// <summary>
        /// The index of the content part that was truncated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The ID of the assistant message item that was truncated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `conversation.item.truncated`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventConversationItemTruncatedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemTruncated" /> class.
        /// </summary>
        /// <param name="audioEndMs">
        /// The duration up to which the audio was truncated, in milliseconds.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part that was truncated.
        /// </param>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the assistant message item that was truncated.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.truncated`.
        /// </param>
        public RealtimeServerEventConversationItemTruncated(
            int audioEndMs,
            int contentIndex,
            string eventId,
            string itemId,
            global::G.RealtimeServerEventConversationItemTruncatedType type)
        {
            this.AudioEndMs = audioEndMs;
            this.ContentIndex = contentIndex;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemTruncated" /> class.
        /// </summary>
        public RealtimeServerEventConversationItemTruncated()
        {
        }
    }
}
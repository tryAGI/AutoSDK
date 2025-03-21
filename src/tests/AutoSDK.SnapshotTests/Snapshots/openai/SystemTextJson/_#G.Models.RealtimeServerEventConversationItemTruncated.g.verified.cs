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
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioEndMs { get; set; }

        /// <summary>
        /// The index of the content part that was truncated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The ID of the assistant message item that was truncated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The event type, must be `conversation.item.truncated`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventConversationItemTruncatedTypeJsonConverter))]
        public global::G.RealtimeServerEventConversationItemTruncatedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
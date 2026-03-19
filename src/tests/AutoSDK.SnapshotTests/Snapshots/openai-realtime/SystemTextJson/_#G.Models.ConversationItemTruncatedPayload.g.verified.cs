//HintName: G.Models.ConversationItemTruncatedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when an assistant audio message item is truncated.
    /// </summary>
    public sealed partial class ConversationItemTruncatedPayload
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationItemTruncatedPayloadTypeJsonConverter))]
        public global::G.ConversationItemTruncatedPayloadType Type { get; set; }

        /// <summary>
        /// The ID of the assistant message item that was truncated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// The index of the content part that was truncated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        public int? ContentIndex { get; set; }

        /// <summary>
        /// The duration up to which the audio was truncated, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_ms")]
        public int? AudioEndMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemTruncatedPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="itemId">
        /// The ID of the assistant message item that was truncated.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part that was truncated.
        /// </param>
        /// <param name="audioEndMs">
        /// The duration up to which the audio was truncated, in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationItemTruncatedPayload(
            string eventId,
            global::G.ConversationItemTruncatedPayloadType type,
            string? itemId,
            int? contentIndex,
            int? audioEndMs)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.ItemId = itemId;
            this.ContentIndex = contentIndex;
            this.AudioEndMs = audioEndMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemTruncatedPayload" /> class.
        /// </summary>
        public ConversationItemTruncatedPayload()
        {
        }
    }
}
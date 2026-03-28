//HintName: G.Models.ConversationItemTruncatePayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to truncate a previous assistant message's audio.
    /// </summary>
    public sealed partial class ConversationItemTruncatePayload
    {
        /// <summary>
        /// Optional client-generated ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationItemTruncatePayloadTypeJsonConverter))]
        public global::G.ConversationItemTruncatePayloadType Type { get; set; }

        /// <summary>
        /// The ID of the assistant message item to truncate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the content part to truncate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// Inclusive duration up to which audio is truncated, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_end_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AudioEndMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemTruncatePayload" /> class.
        /// </summary>
        /// <param name="itemId">
        /// The ID of the assistant message item to truncate.
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part to truncate.
        /// </param>
        /// <param name="audioEndMs">
        /// Inclusive duration up to which audio is truncated, in milliseconds.
        /// </param>
        /// <param name="eventId">
        /// Optional client-generated ID.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationItemTruncatePayload(
            string itemId,
            int contentIndex,
            int audioEndMs,
            string? eventId,
            global::G.ConversationItemTruncatePayloadType type)
        {
            this.EventId = eventId;
            this.Type = type;
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.ContentIndex = contentIndex;
            this.AudioEndMs = audioEndMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemTruncatePayload" /> class.
        /// </summary>
        public ConversationItemTruncatePayload()
        {
        }
    }
}
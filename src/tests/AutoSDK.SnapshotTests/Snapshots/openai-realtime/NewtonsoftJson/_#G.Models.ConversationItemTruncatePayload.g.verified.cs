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
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConversationItemTruncatePayloadTypeJsonConverter))]
        public global::G.ConversationItemTruncatePayloadType Type { get; set; }

        /// <summary>
        /// The ID of the assistant message item to truncate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the content part to truncate.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ContentIndex { get; set; } = default!;

        /// <summary>
        /// Inclusive duration up to which audio is truncated, in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_end_ms", Required = global::Newtonsoft.Json.Required.Always)]
        public int AudioEndMs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
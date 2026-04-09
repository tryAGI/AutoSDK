//HintName: G.Models.ConversationItemDeletedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when an item in the conversation is deleted.
    /// </summary>
    public sealed partial class ConversationItemDeletedPayload
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConversationItemDeletedPayloadTypeJsonConverter))]
        public global::G.ConversationItemDeletedPayloadType Type { get; set; }

        /// <summary>
        /// The ID of the item that was deleted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemDeletedPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item that was deleted.
        /// </param>
        public ConversationItemDeletedPayload(
            string eventId,
            global::G.ConversationItemDeletedPayloadType type,
            string? itemId)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.ItemId = itemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemDeletedPayload" /> class.
        /// </summary>
        public ConversationItemDeletedPayload()
        {
        }
    }
}
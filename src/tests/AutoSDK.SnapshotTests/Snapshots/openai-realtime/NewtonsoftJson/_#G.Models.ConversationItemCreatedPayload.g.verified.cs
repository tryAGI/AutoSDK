//HintName: G.Models.ConversationItemCreatedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a conversation item is created.
    /// </summary>
    public sealed partial class ConversationItemCreatedPayload
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConversationItemCreatedPayloadTypeJsonConverter))]
        public global::G.ConversationItemCreatedPayloadType Type { get; set; }

        /// <summary>
        /// The ID of the preceding item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_item_id")]
        public string? PreviousItemId { get; set; }

        /// <summary>
        /// A realtime conversation item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item")]
        public global::G.ConversationItem? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemCreatedPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="previousItemId">
        /// The ID of the preceding item.
        /// </param>
        /// <param name="item">
        /// A realtime conversation item.
        /// </param>
        public ConversationItemCreatedPayload(
            string eventId,
            global::G.ConversationItemCreatedPayloadType type,
            string? previousItemId,
            global::G.ConversationItem? item)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.PreviousItemId = previousItemId;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemCreatedPayload" /> class.
        /// </summary>
        public ConversationItemCreatedPayload()
        {
        }
    }
}
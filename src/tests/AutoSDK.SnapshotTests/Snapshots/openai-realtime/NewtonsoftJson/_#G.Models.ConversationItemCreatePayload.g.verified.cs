//HintName: G.Models.ConversationItemCreatePayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event when adding an item to the conversation.
    /// </summary>
    public sealed partial class ConversationItemCreatePayload
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
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConversationItemCreatePayloadTypeJsonConverter))]
        public global::G.ConversationItemCreatePayloadType Type { get; set; }

        /// <summary>
        /// The ID of the preceding item after which the new item will be inserted.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_item_id")]
        public string? PreviousItemId { get; set; }

        /// <summary>
        /// A realtime conversation item.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConversationItem Item { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemCreatePayload" /> class.
        /// </summary>
        /// <param name="item">
        /// A realtime conversation item.
        /// </param>
        /// <param name="eventId">
        /// Optional client-generated ID.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="previousItemId">
        /// The ID of the preceding item after which the new item will be inserted.
        /// </param>
        public ConversationItemCreatePayload(
            global::G.ConversationItem item,
            string? eventId,
            global::G.ConversationItemCreatePayloadType type,
            string? previousItemId)
        {
            this.EventId = eventId;
            this.Type = type;
            this.PreviousItemId = previousItemId;
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemCreatePayload" /> class.
        /// </summary>
        public ConversationItemCreatePayload()
        {
        }
    }
}
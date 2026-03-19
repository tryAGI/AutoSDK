//HintName: G.Models.ConversationItemDeletePayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to remove any item from the conversation history.
    /// </summary>
    public sealed partial class ConversationItemDeletePayload
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
        public global::G.ConversationItemDeletePayloadType Type { get; set; }

        /// <summary>
        /// The ID of the item to delete.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemDeletePayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item to delete.
        /// </param>
        public ConversationItemDeletePayload(
            string itemId,
            string? eventId,
            global::G.ConversationItemDeletePayloadType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemDeletePayload" /> class.
        /// </summary>
        public ConversationItemDeletePayload()
        {
        }
    }
}
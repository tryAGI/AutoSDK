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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationItemCreatePayloadTypeJsonConverter))]
        public global::G.ConversationItemCreatePayloadType Type { get; set; }

        /// <summary>
        /// The ID of the preceding item after which the new item will be inserted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_item_id")]
        public string? PreviousItemId { get; set; }

        /// <summary>
        /// A realtime conversation item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConversationItem Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemCreatePayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="previousItemId">
        /// The ID of the preceding item after which the new item will be inserted.
        /// </param>
        /// <param name="item">
        /// A realtime conversation item.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationItemCreatePayload(
            global::G.ConversationItem item,
            string? eventId,
            global::G.ConversationItemCreatePayloadType type,
            string? previousItemId)
        {
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
            this.EventId = eventId;
            this.Type = type;
            this.PreviousItemId = previousItemId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemCreatePayload" /> class.
        /// </summary>
        public ConversationItemCreatePayload()
        {
        }
    }
}
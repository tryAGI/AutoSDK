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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationItemDeletedPayloadTypeJsonConverter))]
        public global::G.ConversationItemDeletedPayloadType Type { get; set; }

        /// <summary>
        /// The ID of the item that was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
//HintName: G.Models.RealtimeServerEventConversationItemDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when an item in the conversation is deleted by the client with a <br/>
    /// `conversation.item.delete` event. This event is used to synchronize the <br/>
    /// server's understanding of the conversation history with the client's view.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationItemDeleted
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `conversation.item.deleted`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventConversationItemDeletedTypeJsonConverter))]
        public global::G.RealtimeServerEventConversationItemDeletedType Type { get; set; }

        /// <summary>
        /// The ID of the item that was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemDeleted" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.deleted`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item that was deleted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventConversationItemDeleted(
            string eventId,
            string itemId,
            global::G.RealtimeServerEventConversationItemDeletedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemDeleted" /> class.
        /// </summary>
        public RealtimeServerEventConversationItemDeleted()
        {
        }
    }
}
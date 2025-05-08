//HintName: G.Models.RealtimeClientEventConversationItemRetrieve.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event when you want to retrieve the server's representation of a specific item in the conversation history. This is useful, for example, to inspect user audio after noise cancellation and VAD.<br/>
    /// The server will respond with a `conversation.item.retrieved` event, <br/>
    /// unless the item does not exist in the conversation history, in which case the <br/>
    /// server will respond with an error.
    /// </summary>
    public sealed partial class RealtimeClientEventConversationItemRetrieve
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `conversation.item.retrieve`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeClientEventConversationItemRetrieveTypeJsonConverter))]
        public global::G.RealtimeClientEventConversationItemRetrieveType Type { get; set; }

        /// <summary>
        /// The ID of the item to retrieve.
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
        /// Initializes a new instance of the <see cref="RealtimeClientEventConversationItemRetrieve" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.retrieve`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the item to retrieve.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeClientEventConversationItemRetrieve(
            string itemId,
            string? eventId,
            global::G.RealtimeClientEventConversationItemRetrieveType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventConversationItemRetrieve" /> class.
        /// </summary>
        public RealtimeClientEventConversationItemRetrieve()
        {
        }
    }
}
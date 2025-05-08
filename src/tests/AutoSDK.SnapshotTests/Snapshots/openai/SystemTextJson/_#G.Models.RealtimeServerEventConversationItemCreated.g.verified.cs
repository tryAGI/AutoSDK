//HintName: G.Models.RealtimeServerEventConversationItemCreated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a conversation item is created. There are several scenarios that produce this event:<br/>
    ///   - The server is generating a Response, which if successful will produce <br/>
    ///     either one or two Items, which will be of type `message` <br/>
    ///     (role `assistant`) or type `function_call`.<br/>
    ///   - The input audio buffer has been committed, either by the client or the <br/>
    ///     server (in `server_vad` mode). The server will take the content of the <br/>
    ///     input audio buffer and add it to a new user message Item.<br/>
    ///   - The client has sent a `conversation.item.create` event to add a new Item <br/>
    ///     to the Conversation.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationItemCreated
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `conversation.item.created`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventConversationItemCreatedTypeJsonConverter))]
        public global::G.RealtimeServerEventConversationItemCreatedType Type { get; set; }

        /// <summary>
        /// The ID of the preceding item in the Conversation context, allows the <br/>
        /// client to understand the order of the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousItemId { get; set; }

        /// <summary>
        /// The item to add to the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RealtimeConversationItem Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.created`.
        /// </param>
        /// <param name="previousItemId">
        /// The ID of the preceding item in the Conversation context, allows the <br/>
        /// client to understand the order of the conversation.
        /// </param>
        /// <param name="item">
        /// The item to add to the conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventConversationItemCreated(
            string eventId,
            string previousItemId,
            global::G.RealtimeConversationItem item,
            global::G.RealtimeServerEventConversationItemCreatedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.PreviousItemId = previousItemId ?? throw new global::System.ArgumentNullException(nameof(previousItemId));
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemCreated" /> class.
        /// </summary>
        public RealtimeServerEventConversationItemCreated()
        {
        }
    }
}
//HintName: G.Models.RealtimeServerEventConversationItemCreated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a conversation item is created. There are several scenarios that <br/>
    /// produce this event:<br/>
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
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `conversation.item.created`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventConversationItemCreatedType Type { get; set; }

        /// <summary>
        /// The ID of the preceding item in the Conversation context, allows the <br/>
        /// client to understand the order of the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_item_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PreviousItemId { get; set; } = default!;

        /// <summary>
        /// The item to add to the conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("item", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeConversationItem Item { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
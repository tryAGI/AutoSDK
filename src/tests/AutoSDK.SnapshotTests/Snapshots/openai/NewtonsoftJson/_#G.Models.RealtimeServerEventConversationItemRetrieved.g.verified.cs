//HintName: G.Models.RealtimeServerEventConversationItemRetrieved.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a conversation item is retrieved with `conversation.item.retrieve`.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationItemRetrieved
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `conversation.item.retrieved`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventConversationItemRetrievedType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemRetrieved" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.item.retrieved`.
        /// </param>
        /// <param name="item">
        /// The item to add to the conversation.
        /// </param>
        public RealtimeServerEventConversationItemRetrieved(
            string eventId,
            global::G.RealtimeConversationItem item,
            global::G.RealtimeServerEventConversationItemRetrievedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationItemRetrieved" /> class.
        /// </summary>
        public RealtimeServerEventConversationItemRetrieved()
        {
        }
    }
}
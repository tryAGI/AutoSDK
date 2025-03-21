//HintName: G.Models.RealtimeServerEventConversationCreated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a conversation is created. Emitted right after session creation.
    /// </summary>
    public sealed partial class RealtimeServerEventConversationCreated
    {
        /// <summary>
        /// The conversation resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeServerEventConversationCreatedConversation Conversation { get; set; } = default!;

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `conversation.created`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventConversationCreatedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationCreated" /> class.
        /// </summary>
        /// <param name="conversation">
        /// The conversation resource.
        /// </param>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `conversation.created`.
        /// </param>
        public RealtimeServerEventConversationCreated(
            global::G.RealtimeServerEventConversationCreatedConversation conversation,
            string eventId,
            global::G.RealtimeServerEventConversationCreatedType type)
        {
            this.Conversation = conversation ?? throw new global::System.ArgumentNullException(nameof(conversation));
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventConversationCreated" /> class.
        /// </summary>
        public RealtimeServerEventConversationCreated()
        {
        }
    }
}
//HintName: G.Models.ConversationCreatedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A new conversation has been created.
    /// </summary>
    public sealed partial class ConversationCreatedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConversationCreatedEventTypeJsonConverter))]
        public global::G.ConversationCreatedEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Conversation information from the server.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation")]
        public global::G.ConversationInfo? Conversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationCreatedEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="conversation">
        /// Conversation information from the server.
        /// </param>
        public ConversationCreatedEvent(
            global::G.ConversationCreatedEventType? type,
            string? eventId,
            global::G.ConversationInfo? conversation)
        {
            this.Type = type;
            this.EventId = eventId;
            this.Conversation = conversation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationCreatedEvent" /> class.
        /// </summary>
        public ConversationCreatedEvent()
        {
        }
    }
}
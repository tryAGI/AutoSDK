//HintName: G.Models.ConversationCreatedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a conversation is created.
    /// </summary>
    public sealed partial class ConversationCreatedPayload
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConversationCreatedPayloadTypeJsonConverter))]
        public global::G.ConversationCreatedPayloadType Type { get; set; }

        /// <summary>
        /// A realtime Conversation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation")]
        public global::G.Conversation? Conversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationCreatedPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="conversation">
        /// A realtime Conversation.
        /// </param>
        public ConversationCreatedPayload(
            string eventId,
            global::G.ConversationCreatedPayloadType type,
            global::G.Conversation? conversation)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.Conversation = conversation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationCreatedPayload" /> class.
        /// </summary>
        public ConversationCreatedPayload()
        {
        }
    }
}
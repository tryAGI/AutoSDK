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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationCreatedPayloadTypeJsonConverter))]
        public global::G.ConversationCreatedPayloadType Type { get; set; }

        /// <summary>
        /// A realtime Conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::G.Conversation? Conversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConversationCreatedEventTypeJsonConverter))]
        public global::G.ConversationCreatedEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Conversation information from the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversation")]
        public global::G.ConversationInfo? Conversation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationCreatedEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="conversation">
        /// Conversation information from the server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
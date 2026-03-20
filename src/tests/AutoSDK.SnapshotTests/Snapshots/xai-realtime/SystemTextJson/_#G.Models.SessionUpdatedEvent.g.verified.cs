//HintName: G.Models.SessionUpdatedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Session configuration has been updated.
    /// </summary>
    public sealed partial class SessionUpdatedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SessionUpdatedEventTypeJsonConverter))]
        public global::G.SessionUpdatedEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Session information from the server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public global::G.SessionInfo? Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionUpdatedEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="session">
        /// Session information from the server.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionUpdatedEvent(
            global::G.SessionUpdatedEventType? type,
            string? eventId,
            global::G.SessionInfo? session)
        {
            this.Type = type;
            this.EventId = eventId;
            this.Session = session;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionUpdatedEvent" /> class.
        /// </summary>
        public SessionUpdatedEvent()
        {
        }
    }
}
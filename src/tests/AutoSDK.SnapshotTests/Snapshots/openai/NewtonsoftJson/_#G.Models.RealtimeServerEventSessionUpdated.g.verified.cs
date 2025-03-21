//HintName: G.Models.RealtimeServerEventSessionUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a session is updated with a `session.update` event, unless <br/>
    /// there is an error.
    /// </summary>
    public sealed partial class RealtimeServerEventSessionUpdated
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// Realtime session object configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeSession Session { get; set; } = default!;

        /// <summary>
        /// The event type, must be `session.updated`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventSessionUpdatedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventSessionUpdated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="session">
        /// Realtime session object configuration.
        /// </param>
        /// <param name="type">
        /// The event type, must be `session.updated`.
        /// </param>
        public RealtimeServerEventSessionUpdated(
            string eventId,
            global::G.RealtimeSession session,
            global::G.RealtimeServerEventSessionUpdatedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventSessionUpdated" /> class.
        /// </summary>
        public RealtimeServerEventSessionUpdated()
        {
        }
    }
}
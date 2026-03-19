//HintName: G.Models.SessionUpdatePayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to update the session's default configuration.
    /// </summary>
    public sealed partial class SessionUpdatePayload
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SessionUpdatePayloadType Type { get; set; }

        /// <summary>
        /// Realtime session configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session")]
        public global::G.Session? Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionUpdatePayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="session">
        /// Realtime session configuration.
        /// </param>
        public SessionUpdatePayload(
            string? eventId,
            global::G.SessionUpdatePayloadType type,
            global::G.Session? session)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Session = session;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionUpdatePayload" /> class.
        /// </summary>
        public SessionUpdatePayload()
        {
        }
    }
}
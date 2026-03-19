//HintName: G.Models.SessionUpdatedPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a session is updated.
    /// </summary>
    public sealed partial class SessionUpdatedPayload
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
        public global::G.SessionUpdatedPayloadType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="SessionUpdatedPayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="session">
        /// Realtime session configuration.
        /// </param>
        public SessionUpdatedPayload(
            string eventId,
            global::G.SessionUpdatedPayloadType type,
            global::G.Session? session)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.Session = session;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionUpdatedPayload" /> class.
        /// </summary>
        public SessionUpdatedPayload()
        {
        }
    }
}
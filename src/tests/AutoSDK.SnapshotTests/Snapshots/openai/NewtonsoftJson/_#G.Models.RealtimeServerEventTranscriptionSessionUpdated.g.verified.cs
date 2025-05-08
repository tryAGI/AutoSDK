//HintName: G.Models.RealtimeServerEventTranscriptionSessionUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when a transcription session is updated with a `transcription_session.update` event, unless <br/>
    /// there is an error.
    /// </summary>
    public sealed partial class RealtimeServerEventTranscriptionSessionUpdated
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `transcription_session.updated`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventTranscriptionSessionUpdatedType Type { get; set; }

        /// <summary>
        /// A new Realtime transcription session configuration.<br/>
        /// When a session is created on the server via REST API, the session object<br/>
        /// also contains an ephemeral key. Default TTL for keys is one minute. This <br/>
        /// property is not present when a session is updated via the WebSocket API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeTranscriptionSessionCreateResponse Session { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventTranscriptionSessionUpdated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `transcription_session.updated`.
        /// </param>
        /// <param name="session">
        /// A new Realtime transcription session configuration.<br/>
        /// When a session is created on the server via REST API, the session object<br/>
        /// also contains an ephemeral key. Default TTL for keys is one minute. This <br/>
        /// property is not present when a session is updated via the WebSocket API.
        /// </param>
        public RealtimeServerEventTranscriptionSessionUpdated(
            string eventId,
            global::G.RealtimeTranscriptionSessionCreateResponse session,
            global::G.RealtimeServerEventTranscriptionSessionUpdatedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventTranscriptionSessionUpdated" /> class.
        /// </summary>
        public RealtimeServerEventTranscriptionSessionUpdated()
        {
        }
    }
}
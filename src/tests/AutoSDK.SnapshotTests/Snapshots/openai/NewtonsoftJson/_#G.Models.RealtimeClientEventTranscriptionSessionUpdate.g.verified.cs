//HintName: G.Models.RealtimeClientEventTranscriptionSessionUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Send this event to update a transcription session.
    /// </summary>
    public sealed partial class RealtimeClientEventTranscriptionSessionUpdate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `transcription_session.update`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeClientEventTranscriptionSessionUpdateType Type { get; set; }

        /// <summary>
        /// Realtime transcription session object configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RealtimeTranscriptionSessionCreateRequest Session { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventTranscriptionSessionUpdate" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `transcription_session.update`.
        /// </param>
        /// <param name="session">
        /// Realtime transcription session object configuration.
        /// </param>
        public RealtimeClientEventTranscriptionSessionUpdate(
            global::G.RealtimeTranscriptionSessionCreateRequest session,
            string? eventId,
            global::G.RealtimeClientEventTranscriptionSessionUpdateType type)
        {
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventTranscriptionSessionUpdate" /> class.
        /// </summary>
        public RealtimeClientEventTranscriptionSessionUpdate()
        {
        }
    }
}
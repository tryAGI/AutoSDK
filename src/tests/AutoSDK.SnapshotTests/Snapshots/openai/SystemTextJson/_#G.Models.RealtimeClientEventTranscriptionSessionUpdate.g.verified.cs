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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `transcription_session.update`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeClientEventTranscriptionSessionUpdateTypeJsonConverter))]
        public global::G.RealtimeClientEventTranscriptionSessionUpdateType Type { get; set; }

        /// <summary>
        /// Realtime transcription session object configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RealtimeTranscriptionSessionCreateRequest Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
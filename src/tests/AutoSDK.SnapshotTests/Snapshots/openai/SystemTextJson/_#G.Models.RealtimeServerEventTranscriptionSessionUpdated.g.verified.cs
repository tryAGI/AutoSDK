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
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `transcription_session.updated`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventTranscriptionSessionUpdatedTypeJsonConverter))]
        public global::G.RealtimeServerEventTranscriptionSessionUpdatedType Type { get; set; }

        /// <summary>
        /// A new Realtime transcription session configuration.<br/>
        /// When a session is created on the server via REST API, the session object<br/>
        /// also contains an ephemeral key. Default TTL for keys is one minute. This <br/>
        /// property is not present when a session is updated via the WebSocket API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RealtimeTranscriptionSessionCreateResponse Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
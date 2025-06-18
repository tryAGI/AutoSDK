//HintName: G.Models.RealtimeServerEventOutputAudioBufferStopped.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **WebRTC Only:** Emitted when the output audio buffer has been completely drained on the server,<br/>
    /// and no more audio is forthcoming. This event is emitted after the full response<br/>
    /// data has been sent to the client (`response.done`).<br/>
    /// [Learn more](/docs/guides/realtime-conversations#client-and-server-events-for-audio-in-webrtc).
    /// </summary>
    public sealed partial class RealtimeServerEventOutputAudioBufferStopped
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `output_audio_buffer.stopped`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventOutputAudioBufferStoppedTypeJsonConverter))]
        public global::G.RealtimeServerEventOutputAudioBufferStoppedType Type { get; set; }

        /// <summary>
        /// The unique ID of the response that produced the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventOutputAudioBufferStopped" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `output_audio_buffer.stopped`.
        /// </param>
        /// <param name="responseId">
        /// The unique ID of the response that produced the audio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventOutputAudioBufferStopped(
            string eventId,
            string responseId,
            global::G.RealtimeServerEventOutputAudioBufferStoppedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventOutputAudioBufferStopped" /> class.
        /// </summary>
        public RealtimeServerEventOutputAudioBufferStopped()
        {
        }
    }
}
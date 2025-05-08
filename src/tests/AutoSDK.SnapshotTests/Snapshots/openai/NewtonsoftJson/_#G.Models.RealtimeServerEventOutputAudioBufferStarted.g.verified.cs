//HintName: G.Models.RealtimeServerEventOutputAudioBufferStarted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **WebRTC Only:** Emitted when the server begins streaming audio to the client. This event is<br/>
    /// emitted after an audio content part has been added (`response.content_part.added`)<br/>
    /// to the response.<br/>
    /// [Learn more](/docs/guides/realtime-model-capabilities#client-and-server-events-for-audio-in-webrtc).
    /// </summary>
    public sealed partial class RealtimeServerEventOutputAudioBufferStarted
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `output_audio_buffer.started`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventOutputAudioBufferStartedType Type { get; set; }

        /// <summary>
        /// The unique ID of the response that produced the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResponseId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventOutputAudioBufferStarted" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `output_audio_buffer.started`.
        /// </param>
        /// <param name="responseId">
        /// The unique ID of the response that produced the audio.
        /// </param>
        public RealtimeServerEventOutputAudioBufferStarted(
            string eventId,
            string responseId,
            global::G.RealtimeServerEventOutputAudioBufferStartedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventOutputAudioBufferStarted" /> class.
        /// </summary>
        public RealtimeServerEventOutputAudioBufferStarted()
        {
        }
    }
}
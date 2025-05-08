//HintName: G.Models.RealtimeServerEventOutputAudioBufferStopped.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **WebRTC Only:** Emitted when the output audio buffer has been completely drained on the server,<br/>
    /// and no more audio is forthcoming. This event is emitted after the full response<br/>
    /// data has been sent to the client (`response.done`).<br/>
    /// [Learn more](/docs/guides/realtime-model-capabilities#client-and-server-events-for-audio-in-webrtc).
    /// </summary>
    public sealed partial class RealtimeServerEventOutputAudioBufferStopped
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `output_audio_buffer.stopped`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RealtimeServerEventOutputAudioBufferStoppedType Type { get; set; }

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
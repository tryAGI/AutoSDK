//HintName: G.Models.InputAudioBufferSpeechStoppedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Speech has stopped in audio input (VAD).
    /// </summary>
    public sealed partial class InputAudioBufferSpeechStoppedEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputAudioBufferSpeechStoppedEventType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferSpeechStoppedEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        public InputAudioBufferSpeechStoppedEvent(
            global::G.InputAudioBufferSpeechStoppedEventType? type,
            string? eventId)
        {
            this.Type = type;
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputAudioBufferSpeechStoppedEvent" /> class.
        /// </summary>
        public InputAudioBufferSpeechStoppedEvent()
        {
        }
    }
}
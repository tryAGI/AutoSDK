//HintName: G.Models.ResponseAudioDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when the audio response is complete.
    /// </summary>
    public sealed partial class ResponseAudioDoneEvent
    {
        /// <summary>
        /// The type of the event. Always `response.audio.done`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseAudioDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.audio.done`.
        /// </param>
        public ResponseAudioDoneEvent(
            global::G.ResponseAudioDoneEventType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioDoneEvent" /> class.
        /// </summary>
        public ResponseAudioDoneEvent()
        {
        }
    }
}
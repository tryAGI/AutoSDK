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
        /// The sequence number of the delta.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

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
        /// <param name="sequenceNumber">
        /// The sequence number of the delta.
        /// </param>
        public ResponseAudioDoneEvent(
            int sequenceNumber,
            global::G.ResponseAudioDoneEventType type)
        {
            this.SequenceNumber = sequenceNumber;
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
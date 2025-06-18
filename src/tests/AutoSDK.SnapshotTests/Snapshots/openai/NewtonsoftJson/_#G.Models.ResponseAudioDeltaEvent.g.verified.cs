//HintName: G.Models.ResponseAudioDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when there is a partial audio response.
    /// </summary>
    public sealed partial class ResponseAudioDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always `response.audio.delta`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseAudioDeltaEventType Type { get; set; }

        /// <summary>
        /// A sequence number for this chunk of the stream response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// A chunk of Base64 encoded response audio bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delta", Required = global::Newtonsoft.Json.Required.Always)]
        public string Delta { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.audio.delta`.
        /// </param>
        /// <param name="sequenceNumber">
        /// A sequence number for this chunk of the stream response.
        /// </param>
        /// <param name="delta">
        /// A chunk of Base64 encoded response audio bytes.
        /// </param>
        public ResponseAudioDeltaEvent(
            int sequenceNumber,
            string delta,
            global::G.ResponseAudioDeltaEventType type)
        {
            this.SequenceNumber = sequenceNumber;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAudioDeltaEvent" /> class.
        /// </summary>
        public ResponseAudioDeltaEvent()
        {
        }
    }
}
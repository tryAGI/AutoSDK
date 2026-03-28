//HintName: G.Models.TranscriptResultPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Transcript result from the server.
    /// </summary>
    public sealed partial class TranscriptResultPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public global::G.TranscriptResultPayloadMessageType MessageType { get; set; }

        /// <summary>
        /// The transcript text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Whether this is a final result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_final", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsFinal { get; set; } = default!;

        /// <summary>
        /// Confidence score.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptResultPayload" /> class.
        /// </summary>
        /// <param name="text">
        /// The transcript text.
        /// </param>
        /// <param name="isFinal">
        /// Whether this is a final result.
        /// </param>
        /// <param name="messageType"></param>
        /// <param name="confidence">
        /// Confidence score.
        /// </param>
        public TranscriptResultPayload(
            string text,
            bool isFinal,
            global::G.TranscriptResultPayloadMessageType messageType,
            double? confidence)
        {
            this.MessageType = messageType;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.IsFinal = isFinal;
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriptResultPayload" /> class.
        /// </summary>
        public TranscriptResultPayload()
        {
        }
    }
}
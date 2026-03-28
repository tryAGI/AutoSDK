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
        /// <default>"transcript_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        public string MessageType { get; set; } = "transcript_result";

        /// <summary>
        /// The transcript text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Whether this is a final result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_final")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFinal { get; set; }

        /// <summary>
        /// Confidence score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// <param name="confidence">
        /// Confidence score.
        /// </param>
        /// <param name="messageType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriptResultPayload(
            string text,
            bool isFinal,
            double? confidence,
            string messageType = "transcript_result")
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
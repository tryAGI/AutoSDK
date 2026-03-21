//HintName: G.Models.ListenV1ResultsChannelAlternatives.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A transcription alternative.
    /// </summary>
    public sealed partial class ListenV1ResultsChannelAlternatives
    {
        /// <summary>
        /// The transcript text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcript")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transcript { get; set; }

        /// <summary>
        /// Confidence score.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResultsChannelAlternatives" /> class.
        /// </summary>
        /// <param name="transcript">
        /// The transcript text.
        /// </param>
        /// <param name="confidence">
        /// Confidence score.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1ResultsChannelAlternatives(
            string transcript,
            double confidence)
        {
            this.Transcript = transcript ?? throw new global::System.ArgumentNullException(nameof(transcript));
            this.Confidence = confidence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1ResultsChannelAlternatives" /> class.
        /// </summary>
        public ListenV1ResultsChannelAlternatives()
        {
        }
    }
}
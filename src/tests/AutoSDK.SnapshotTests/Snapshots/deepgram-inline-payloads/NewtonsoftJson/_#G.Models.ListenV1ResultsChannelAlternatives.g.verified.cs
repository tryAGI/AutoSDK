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
        [global::Newtonsoft.Json.JsonProperty("transcript", Required = global::Newtonsoft.Json.Required.Always)]
        public string Transcript { get; set; } = default!;

        /// <summary>
        /// Confidence score.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("confidence", Required = global::Newtonsoft.Json.Required.Always)]
        public double Confidence { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
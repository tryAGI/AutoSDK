//HintName: G.Models.SentimentAnalysisResultSentimentAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Holds the detailed sentiment analysis information.
    /// </summary>
    public sealed partial class SentimentAnalysisResultSentimentAnalysis
    {
        /// <summary>
        /// An array of objects that represent a segment of text and its associated sentiment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segments")]
        public global::System.Collections.Generic.IList<global::G.SentimentSegment>? Segments { get; set; }

        /// <summary>
        /// Holds overall sentiment information, as well as detailed per-speaker and per-channel sentiment data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::G.SentimentSummary? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisResultSentimentAnalysis" /> class.
        /// </summary>
        /// <param name="segments">
        /// An array of objects that represent a segment of text and its associated sentiment.
        /// </param>
        /// <param name="summary">
        /// Holds overall sentiment information, as well as detailed per-speaker and per-channel sentiment data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentimentAnalysisResultSentimentAnalysis(
            global::System.Collections.Generic.IList<global::G.SentimentSegment>? segments,
            global::G.SentimentSummary? summary)
        {
            this.Segments = segments;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisResultSentimentAnalysis" /> class.
        /// </summary>
        public SentimentAnalysisResultSentimentAnalysis()
        {
        }
    }
}
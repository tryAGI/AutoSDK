//HintName: G.Models.SentimentAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SentimentAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OneOf<global::G.SentimentAnalysisDetailVariant1, global::G.SentimentAnalysisDetailVariant2>> Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PositiveCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neutral_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NeutralCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NegativeCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="positiveCount"></param>
        /// <param name="neutralCount"></param>
        /// <param name="negativeCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentimentAnalysis(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SentimentAnalysisDetailVariant1, global::G.SentimentAnalysisDetailVariant2>> details,
            double positiveCount,
            double neutralCount,
            double negativeCount)
        {
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
            this.PositiveCount = positiveCount;
            this.NeutralCount = neutralCount;
            this.NegativeCount = negativeCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysis" /> class.
        /// </summary>
        public SentimentAnalysis()
        {
        }
    }
}
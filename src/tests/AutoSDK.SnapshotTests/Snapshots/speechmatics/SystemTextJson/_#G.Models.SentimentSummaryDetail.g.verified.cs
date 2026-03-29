//HintName: G.Models.SentimentSummaryDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Holds the count of sentiment information grouped by positive, neutral and negative.
    /// </summary>
    public sealed partial class SentimentSummaryDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive_count")]
        public int? PositiveCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_count")]
        public int? NegativeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("neutral_count")]
        public int? NeutralCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentSummaryDetail" /> class.
        /// </summary>
        /// <param name="positiveCount"></param>
        /// <param name="negativeCount"></param>
        /// <param name="neutralCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentimentSummaryDetail(
            int? positiveCount,
            int? negativeCount,
            int? neutralCount)
        {
            this.PositiveCount = positiveCount;
            this.NegativeCount = negativeCount;
            this.NeutralCount = neutralCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentSummaryDetail" /> class.
        /// </summary>
        public SentimentSummaryDetail()
        {
        }
    }
}
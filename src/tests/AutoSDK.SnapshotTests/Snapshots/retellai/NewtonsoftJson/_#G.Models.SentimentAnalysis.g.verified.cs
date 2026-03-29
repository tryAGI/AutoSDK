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
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.SentimentAnalysisDetailVariant1, global::G.SentimentAnalysisDetailVariant2>> Details { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("positive_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double PositiveCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("neutral_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double NeutralCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("negative_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double NegativeCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysis" /> class.
        /// </summary>
        /// <param name="details"></param>
        /// <param name="positiveCount"></param>
        /// <param name="neutralCount"></param>
        /// <param name="negativeCount"></param>
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
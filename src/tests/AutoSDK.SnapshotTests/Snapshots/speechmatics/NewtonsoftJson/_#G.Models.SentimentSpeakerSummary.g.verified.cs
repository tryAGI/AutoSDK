//HintName: G.Models.SentimentSpeakerSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Holds sentiment information for a specific speaker.
    /// </summary>
    public sealed partial class SentimentSpeakerSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speaker")]
        public string? Speaker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("positive_count")]
        public int? PositiveCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("negative_count")]
        public int? NegativeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("neutral_count")]
        public int? NeutralCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentSpeakerSummary" /> class.
        /// </summary>
        /// <param name="speaker"></param>
        /// <param name="positiveCount"></param>
        /// <param name="negativeCount"></param>
        /// <param name="neutralCount"></param>
        public SentimentSpeakerSummary(
            string? speaker,
            int? positiveCount,
            int? negativeCount,
            int? neutralCount)
        {
            this.Speaker = speaker;
            this.PositiveCount = positiveCount;
            this.NegativeCount = negativeCount;
            this.NeutralCount = neutralCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentSpeakerSummary" /> class.
        /// </summary>
        public SentimentSpeakerSummary()
        {
        }
    }
}
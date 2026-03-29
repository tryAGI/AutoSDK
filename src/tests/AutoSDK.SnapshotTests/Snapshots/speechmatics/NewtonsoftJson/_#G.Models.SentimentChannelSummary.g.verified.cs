//HintName: G.Models.SentimentChannelSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Holds sentiment information for a specific channel.
    /// </summary>
    public sealed partial class SentimentChannelSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channel")]
        public string? Channel { get; set; }

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
        /// Initializes a new instance of the <see cref="SentimentChannelSummary" /> class.
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="positiveCount"></param>
        /// <param name="negativeCount"></param>
        /// <param name="neutralCount"></param>
        public SentimentChannelSummary(
            string? channel,
            int? positiveCount,
            int? negativeCount,
            int? neutralCount)
        {
            this.Channel = channel;
            this.PositiveCount = positiveCount;
            this.NegativeCount = negativeCount;
            this.NeutralCount = neutralCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentChannelSummary" /> class.
        /// </summary>
        public SentimentChannelSummary()
        {
        }
    }
}
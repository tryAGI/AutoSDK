//HintName: G.Models.SentimentAnalysisDetailVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SentimentAnalysisDetailVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_id")]
        public double? ResponseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sentiment")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SentimentAnalysisDetailVariant2SentimentJsonConverter))]
        public global::G.SentimentAnalysisDetailVariant2Sentiment? Sentiment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisDetailVariant2" /> class.
        /// </summary>
        /// <param name="responseId"></param>
        /// <param name="sentiment"></param>
        public SentimentAnalysisDetailVariant2(
            double? responseId,
            global::G.SentimentAnalysisDetailVariant2Sentiment? sentiment)
        {
            this.ResponseId = responseId;
            this.Sentiment = sentiment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisDetailVariant2" /> class.
        /// </summary>
        public SentimentAnalysisDetailVariant2()
        {
        }
    }
}
//HintName: G.Models.SentimentAnalysisResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The main object that holds sentiment analysis data.<br/>
    /// Example: {"segments":[{"text":"I am happy with the product.","start_time":0,"end_time":5,"sentiment":"positive","speaker":"John Doe","channel":"Chat","confidence":0.9},{"text":"I don\u0027t like the customer service.","start_time":6,"end_time":12,"sentiment":"negative","speaker":"John Doe","channel":"Chat","confidence":0.8}],"summary":{"overall":{"positive_count":1,"negative_count":1,"neutral_count":0},"speakers":[{"speaker":"John Doe","positive_count":1,"negative_count":1,"neutral_count":0}],"channels":[{"channel":"Chat","positive_count":1,"negative_count":1,"neutral_count":0}]}}
    /// </summary>
    public sealed partial class SentimentAnalysisResult
    {
        /// <summary>
        /// Holds the detailed sentiment analysis information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment_analysis")]
        public global::G.SentimentAnalysisResultSentimentAnalysis? SentimentAnalysis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisResult" /> class.
        /// </summary>
        /// <param name="sentimentAnalysis">
        /// Holds the detailed sentiment analysis information.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentimentAnalysisResult(
            global::G.SentimentAnalysisResultSentimentAnalysis? sentimentAnalysis)
        {
            this.SentimentAnalysis = sentimentAnalysis;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisResult" /> class.
        /// </summary>
        public SentimentAnalysisResult()
        {
        }
    }
}
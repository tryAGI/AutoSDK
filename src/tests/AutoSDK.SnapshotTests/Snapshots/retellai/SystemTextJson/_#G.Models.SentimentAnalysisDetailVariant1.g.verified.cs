//HintName: G.Models.SentimentAnalysisDetailVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SentimentAnalysisDetailVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public global::G.Duration? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SentimentAnalysisDetailVariant1SentimentJsonConverter))]
        public global::G.SentimentAnalysisDetailVariant1Sentiment? Sentiment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisDetailVariant1" /> class.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="sentiment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentimentAnalysisDetailVariant1(
            global::G.Duration? duration,
            global::G.SentimentAnalysisDetailVariant1Sentiment? sentiment)
        {
            this.Duration = duration;
            this.Sentiment = sentiment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentAnalysisDetailVariant1" /> class.
        /// </summary>
        public SentimentAnalysisDetailVariant1()
        {
        }
    }
}
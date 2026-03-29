//HintName: G.Models.SentimentMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SentimentMessage
    {
        /// <summary>
        /// Text content analyzed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Sentiment score from -1.0 (negative) to 1.0 (positive)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// Overall sentiment classification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentiment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SentimentMessageSentimentJsonConverter))]
        public global::G.SentimentMessageSentiment? Sentiment { get; set; }

        /// <summary>
        /// Start offset timestamp in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public double? Offset { get; set; }

        /// <summary>
        /// Length/duration in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        public double? Length { get; set; }

        /// <summary>
        /// Start timestamp in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ts")]
        public double? Ts { get; set; }

        /// <summary>
        /// End timestamp in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_ts")]
        public double? EndTs { get; set; }

        /// <summary>
        /// Speaker ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speaker")]
        public int? Speaker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// Text content analyzed
        /// </param>
        /// <param name="score">
        /// Sentiment score from -1.0 (negative) to 1.0 (positive)
        /// </param>
        /// <param name="sentiment">
        /// Overall sentiment classification
        /// </param>
        /// <param name="offset">
        /// Start offset timestamp in seconds
        /// </param>
        /// <param name="length">
        /// Length/duration in seconds
        /// </param>
        /// <param name="ts">
        /// Start timestamp in seconds
        /// </param>
        /// <param name="endTs">
        /// End timestamp in seconds
        /// </param>
        /// <param name="speaker">
        /// Speaker ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentimentMessage(
            string? content,
            double? score,
            global::G.SentimentMessageSentiment? sentiment,
            double? offset,
            double? length,
            double? ts,
            double? endTs,
            int? speaker)
        {
            this.Content = content;
            this.Score = score;
            this.Sentiment = sentiment;
            this.Offset = offset;
            this.Length = length;
            this.Ts = ts;
            this.EndTs = endTs;
            this.Speaker = speaker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentimentMessage" /> class.
        /// </summary>
        public SentimentMessage()
        {
        }
    }
}
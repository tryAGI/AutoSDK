//HintName: G.Models.SentimentAnalysisDetailVariant2Sentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SentimentAnalysisDetailVariant2Sentiment
    {
        /// <summary>
        /// 
        /// </summary>
        Negative,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Positive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SentimentAnalysisDetailVariant2SentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SentimentAnalysisDetailVariant2Sentiment value)
        {
            return value switch
            {
                SentimentAnalysisDetailVariant2Sentiment.Negative => "negative",
                SentimentAnalysisDetailVariant2Sentiment.Neutral => "neutral",
                SentimentAnalysisDetailVariant2Sentiment.Positive => "positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SentimentAnalysisDetailVariant2Sentiment? ToEnum(string value)
        {
            return value switch
            {
                "negative" => SentimentAnalysisDetailVariant2Sentiment.Negative,
                "neutral" => SentimentAnalysisDetailVariant2Sentiment.Neutral,
                "positive" => SentimentAnalysisDetailVariant2Sentiment.Positive,
                _ => null,
            };
        }
    }
}
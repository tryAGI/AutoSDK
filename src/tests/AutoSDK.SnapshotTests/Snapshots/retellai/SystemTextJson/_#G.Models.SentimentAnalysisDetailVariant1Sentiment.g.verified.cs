//HintName: G.Models.SentimentAnalysisDetailVariant1Sentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SentimentAnalysisDetailVariant1Sentiment
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
    public static class SentimentAnalysisDetailVariant1SentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SentimentAnalysisDetailVariant1Sentiment value)
        {
            return value switch
            {
                SentimentAnalysisDetailVariant1Sentiment.Negative => "negative",
                SentimentAnalysisDetailVariant1Sentiment.Neutral => "neutral",
                SentimentAnalysisDetailVariant1Sentiment.Positive => "positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SentimentAnalysisDetailVariant1Sentiment? ToEnum(string value)
        {
            return value switch
            {
                "negative" => SentimentAnalysisDetailVariant1Sentiment.Negative,
                "neutral" => SentimentAnalysisDetailVariant1Sentiment.Neutral,
                "positive" => SentimentAnalysisDetailVariant1Sentiment.Positive,
                _ => null,
            };
        }
    }
}
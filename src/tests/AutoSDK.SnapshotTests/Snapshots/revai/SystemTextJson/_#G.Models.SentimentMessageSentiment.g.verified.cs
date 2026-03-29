//HintName: G.Models.SentimentMessageSentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Overall sentiment classification
    /// </summary>
    public enum SentimentMessageSentiment
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
    public static class SentimentMessageSentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SentimentMessageSentiment value)
        {
            return value switch
            {
                SentimentMessageSentiment.Negative => "negative",
                SentimentMessageSentiment.Neutral => "neutral",
                SentimentMessageSentiment.Positive => "positive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SentimentMessageSentiment? ToEnum(string value)
        {
            return value switch
            {
                "negative" => SentimentMessageSentiment.Negative,
                "neutral" => SentimentMessageSentiment.Neutral,
                "positive" => SentimentMessageSentiment.Positive,
                _ => null,
            };
        }
    }
}
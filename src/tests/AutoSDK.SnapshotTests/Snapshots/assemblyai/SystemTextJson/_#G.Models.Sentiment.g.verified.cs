//HintName: G.Models.Sentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Sentiment
    {
        /// <summary>
        /// 
        /// </summary>
        Positive,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Negative,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Sentiment value)
        {
            return value switch
            {
                Sentiment.Positive => "POSITIVE",
                Sentiment.Neutral => "NEUTRAL",
                Sentiment.Negative => "NEGATIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Sentiment? ToEnum(string value)
        {
            return value switch
            {
                "POSITIVE" => Sentiment.Positive,
                "NEUTRAL" => Sentiment.Neutral,
                "NEGATIVE" => Sentiment.Negative,
                _ => null,
            };
        }
    }
}
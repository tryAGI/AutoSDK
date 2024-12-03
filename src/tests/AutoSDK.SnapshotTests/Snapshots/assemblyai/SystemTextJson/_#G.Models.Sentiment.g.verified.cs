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
        POSITIVE,
        /// <summary>
        /// 
        /// </summary>
        NEUTRAL,
        /// <summary>
        /// 
        /// </summary>
        NEGATIVE,
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
                Sentiment.POSITIVE => "POSITIVE",
                Sentiment.NEUTRAL => "NEUTRAL",
                Sentiment.NEGATIVE => "NEGATIVE",
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
                "POSITIVE" => Sentiment.POSITIVE,
                "NEUTRAL" => Sentiment.NEUTRAL,
                "NEGATIVE" => Sentiment.NEGATIVE,
                _ => null,
            };
        }
    }
}
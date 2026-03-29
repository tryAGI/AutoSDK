//HintName: G.Models.CallFilterUserSentimentValueItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CallFilterUserSentimentValueItem
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
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallFilterUserSentimentValueItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallFilterUserSentimentValueItem value)
        {
            return value switch
            {
                CallFilterUserSentimentValueItem.Negative => "Negative",
                CallFilterUserSentimentValueItem.Neutral => "Neutral",
                CallFilterUserSentimentValueItem.Positive => "Positive",
                CallFilterUserSentimentValueItem.Unknown => "Unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallFilterUserSentimentValueItem? ToEnum(string value)
        {
            return value switch
            {
                "Negative" => CallFilterUserSentimentValueItem.Negative,
                "Neutral" => CallFilterUserSentimentValueItem.Neutral,
                "Positive" => CallFilterUserSentimentValueItem.Positive,
                "Unknown" => CallFilterUserSentimentValueItem.Unknown,
                _ => null,
            };
        }
    }
}
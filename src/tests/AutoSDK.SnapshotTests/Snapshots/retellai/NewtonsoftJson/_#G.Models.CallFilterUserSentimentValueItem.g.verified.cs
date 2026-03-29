//HintName: G.Models.CallFilterUserSentimentValueItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallFilterUserSentimentValueItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Negative")]
        Negative,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Neutral")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Positive")]
        Positive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Unknown")]
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
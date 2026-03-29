//HintName: G.Models.SentimentMessageSentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Overall sentiment classification
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SentimentMessageSentiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="negative")]
        Negative,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="positive")]
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
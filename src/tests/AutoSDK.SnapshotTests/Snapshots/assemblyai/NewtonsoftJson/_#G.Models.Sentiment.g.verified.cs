//HintName: G.Models.Sentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sentiment
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Sentiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NEGATIVE")]
        Negative,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NEUTRAL")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="POSITIVE")]
        Positive,
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
                Sentiment.Negative => "NEGATIVE",
                Sentiment.Neutral => "NEUTRAL",
                Sentiment.Positive => "POSITIVE",
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
                "NEGATIVE" => Sentiment.Negative,
                "NEUTRAL" => Sentiment.Neutral,
                "POSITIVE" => Sentiment.Positive,
                _ => null,
            };
        }
    }
}
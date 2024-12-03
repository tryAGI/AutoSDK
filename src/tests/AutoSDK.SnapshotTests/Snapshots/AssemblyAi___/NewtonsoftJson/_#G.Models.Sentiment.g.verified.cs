//HintName: G.Models.Sentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Sentiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="POSITIVE")]
        POSITIVE,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NEUTRAL")]
        NEUTRAL,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NEGATIVE")]
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
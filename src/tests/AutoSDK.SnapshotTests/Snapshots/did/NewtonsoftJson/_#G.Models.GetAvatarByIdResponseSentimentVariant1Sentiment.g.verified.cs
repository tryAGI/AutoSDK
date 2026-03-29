//HintName: G.Models.GetAvatarByIdResponseSentimentVariant1Sentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sentiment of the avatar's expression<br/>
    /// Example: happy
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAvatarByIdResponseSentimentVariant1Sentiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Empathetic")]
        Empathetic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Excited")]
        Excited,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Friendly")]
        Friendly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Frustrated")]
        Frustrated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Professional")]
        Professional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatarByIdResponseSentimentVariant1SentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarByIdResponseSentimentVariant1Sentiment value)
        {
            return value switch
            {
                GetAvatarByIdResponseSentimentVariant1Sentiment.Empathetic => "Empathetic",
                GetAvatarByIdResponseSentimentVariant1Sentiment.Excited => "Excited",
                GetAvatarByIdResponseSentimentVariant1Sentiment.Friendly => "Friendly",
                GetAvatarByIdResponseSentimentVariant1Sentiment.Frustrated => "Frustrated",
                GetAvatarByIdResponseSentimentVariant1Sentiment.Professional => "Professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarByIdResponseSentimentVariant1Sentiment? ToEnum(string value)
        {
            return value switch
            {
                "Empathetic" => GetAvatarByIdResponseSentimentVariant1Sentiment.Empathetic,
                "Excited" => GetAvatarByIdResponseSentimentVariant1Sentiment.Excited,
                "Friendly" => GetAvatarByIdResponseSentimentVariant1Sentiment.Friendly,
                "Frustrated" => GetAvatarByIdResponseSentimentVariant1Sentiment.Frustrated,
                "Professional" => GetAvatarByIdResponseSentimentVariant1Sentiment.Professional,
                _ => null,
            };
        }
    }
}
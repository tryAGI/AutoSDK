//HintName: G.Models.GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sentiment of the avatar's expression<br/>
    /// Example: happy
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment
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
    public static class GetExpressiveAvatarDtoVariant2SentimentVariant1SentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment value)
        {
            return value switch
            {
                GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment.Empathetic => "Empathetic",
                GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment.Excited => "Excited",
                GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment.Friendly => "Friendly",
                GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment.Frustrated => "Frustrated",
                GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment.Professional => "Professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment? ToEnum(string value)
        {
            return value switch
            {
                "Empathetic" => GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment.Empathetic,
                "Excited" => GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment.Excited,
                "Friendly" => GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment.Friendly,
                "Frustrated" => GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment.Frustrated,
                "Professional" => GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment.Professional,
                _ => null,
            };
        }
    }
}
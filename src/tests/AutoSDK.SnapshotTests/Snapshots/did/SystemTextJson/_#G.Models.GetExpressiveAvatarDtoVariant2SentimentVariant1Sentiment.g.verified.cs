//HintName: G.Models.GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sentiment of the avatar's expression<br/>
    /// Example: happy
    /// </summary>
    public enum GetExpressiveAvatarDtoVariant2SentimentVariant1Sentiment
    {
        /// <summary>
        /// 
        /// </summary>
        Empathetic,
        /// <summary>
        /// 
        /// </summary>
        Excited,
        /// <summary>
        /// 
        /// </summary>
        Friendly,
        /// <summary>
        /// 
        /// </summary>
        Frustrated,
        /// <summary>
        /// 
        /// </summary>
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
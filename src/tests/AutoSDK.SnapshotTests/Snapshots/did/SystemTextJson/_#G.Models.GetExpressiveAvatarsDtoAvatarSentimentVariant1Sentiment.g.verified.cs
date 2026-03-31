//HintName: G.Models.GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sentiment of the avatar's expression<br/>
    /// Example: happy
    /// </summary>
    public enum GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment
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
    public static class GetExpressiveAvatarsDtoAvatarSentimentVariant1SentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment value)
        {
            return value switch
            {
                GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment.Empathetic => "Empathetic",
                GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment.Excited => "Excited",
                GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment.Friendly => "Friendly",
                GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment.Frustrated => "Frustrated",
                GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment.Professional => "Professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment? ToEnum(string value)
        {
            return value switch
            {
                "Empathetic" => GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment.Empathetic,
                "Excited" => GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment.Excited,
                "Friendly" => GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment.Friendly,
                "Frustrated" => GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment.Frustrated,
                "Professional" => GetExpressiveAvatarsDtoAvatarSentimentVariant1Sentiment.Professional,
                _ => null,
            };
        }
    }
}
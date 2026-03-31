//HintName: G.Models.ExpressiveAvatarExpressionDtoVariant1Sentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sentiment of the avatar's expression<br/>
    /// Example: happy
    /// </summary>
    public enum ExpressiveAvatarExpressionDtoVariant1Sentiment
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
    public static class ExpressiveAvatarExpressionDtoVariant1SentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAvatarExpressionDtoVariant1Sentiment value)
        {
            return value switch
            {
                ExpressiveAvatarExpressionDtoVariant1Sentiment.Empathetic => "Empathetic",
                ExpressiveAvatarExpressionDtoVariant1Sentiment.Excited => "Excited",
                ExpressiveAvatarExpressionDtoVariant1Sentiment.Friendly => "Friendly",
                ExpressiveAvatarExpressionDtoVariant1Sentiment.Frustrated => "Frustrated",
                ExpressiveAvatarExpressionDtoVariant1Sentiment.Professional => "Professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAvatarExpressionDtoVariant1Sentiment? ToEnum(string value)
        {
            return value switch
            {
                "Empathetic" => ExpressiveAvatarExpressionDtoVariant1Sentiment.Empathetic,
                "Excited" => ExpressiveAvatarExpressionDtoVariant1Sentiment.Excited,
                "Friendly" => ExpressiveAvatarExpressionDtoVariant1Sentiment.Friendly,
                "Frustrated" => ExpressiveAvatarExpressionDtoVariant1Sentiment.Frustrated,
                "Professional" => ExpressiveAvatarExpressionDtoVariant1Sentiment.Professional,
                _ => null,
            };
        }
    }
}
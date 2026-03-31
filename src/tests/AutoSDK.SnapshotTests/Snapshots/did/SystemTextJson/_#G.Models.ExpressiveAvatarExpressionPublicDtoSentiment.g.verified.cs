//HintName: G.Models.ExpressiveAvatarExpressionPublicDtoSentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sentiment of the avatar's expression<br/>
    /// Example: happy
    /// </summary>
    public enum ExpressiveAvatarExpressionPublicDtoSentiment
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
    public static class ExpressiveAvatarExpressionPublicDtoSentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressiveAvatarExpressionPublicDtoSentiment value)
        {
            return value switch
            {
                ExpressiveAvatarExpressionPublicDtoSentiment.Empathetic => "Empathetic",
                ExpressiveAvatarExpressionPublicDtoSentiment.Excited => "Excited",
                ExpressiveAvatarExpressionPublicDtoSentiment.Friendly => "Friendly",
                ExpressiveAvatarExpressionPublicDtoSentiment.Frustrated => "Frustrated",
                ExpressiveAvatarExpressionPublicDtoSentiment.Professional => "Professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressiveAvatarExpressionPublicDtoSentiment? ToEnum(string value)
        {
            return value switch
            {
                "Empathetic" => ExpressiveAvatarExpressionPublicDtoSentiment.Empathetic,
                "Excited" => ExpressiveAvatarExpressionPublicDtoSentiment.Excited,
                "Friendly" => ExpressiveAvatarExpressionPublicDtoSentiment.Friendly,
                "Frustrated" => ExpressiveAvatarExpressionPublicDtoSentiment.Frustrated,
                "Professional" => ExpressiveAvatarExpressionPublicDtoSentiment.Professional,
                _ => null,
            };
        }
    }
}
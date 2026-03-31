//HintName: G.Models.Expression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Expression
    {
        /// <summary>
        /// 
        /// </summary>
        Happy,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Serious,
        /// <summary>
        /// 
        /// </summary>
        Surprise,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExpressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Expression value)
        {
            return value switch
            {
                Expression.Happy => "happy",
                Expression.Neutral => "neutral",
                Expression.Serious => "serious",
                Expression.Surprise => "surprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Expression? ToEnum(string value)
        {
            return value switch
            {
                "happy" => Expression.Happy,
                "neutral" => Expression.Neutral,
                "serious" => Expression.Serious,
                "surprise" => Expression.Surprise,
                _ => null,
            };
        }
    }
}
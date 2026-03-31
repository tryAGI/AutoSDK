//HintName: G.Models.CreateTalkRequestConfigDriverExpressionsExpressionExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The expression to use
    /// </summary>
    public enum CreateTalkRequestConfigDriverExpressionsExpressionExpression
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
    public static class CreateTalkRequestConfigDriverExpressionsExpressionExpressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkRequestConfigDriverExpressionsExpressionExpression value)
        {
            return value switch
            {
                CreateTalkRequestConfigDriverExpressionsExpressionExpression.Happy => "happy",
                CreateTalkRequestConfigDriverExpressionsExpressionExpression.Neutral => "neutral",
                CreateTalkRequestConfigDriverExpressionsExpressionExpression.Serious => "serious",
                CreateTalkRequestConfigDriverExpressionsExpressionExpression.Surprise => "surprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkRequestConfigDriverExpressionsExpressionExpression? ToEnum(string value)
        {
            return value switch
            {
                "happy" => CreateTalkRequestConfigDriverExpressionsExpressionExpression.Happy,
                "neutral" => CreateTalkRequestConfigDriverExpressionsExpressionExpression.Neutral,
                "serious" => CreateTalkRequestConfigDriverExpressionsExpressionExpression.Serious,
                "surprise" => CreateTalkRequestConfigDriverExpressionsExpressionExpression.Surprise,
                _ => null,
            };
        }
    }
}
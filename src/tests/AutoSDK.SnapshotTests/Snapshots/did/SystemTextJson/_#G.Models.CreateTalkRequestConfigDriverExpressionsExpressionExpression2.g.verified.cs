//HintName: G.Models.CreateTalkRequestConfigDriverExpressionsExpressionExpression2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The expression to use
    /// </summary>
    public enum CreateTalkRequestConfigDriverExpressionsExpressionExpression2
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
    public static class CreateTalkRequestConfigDriverExpressionsExpressionExpression2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTalkRequestConfigDriverExpressionsExpressionExpression2 value)
        {
            return value switch
            {
                CreateTalkRequestConfigDriverExpressionsExpressionExpression2.Happy => "happy",
                CreateTalkRequestConfigDriverExpressionsExpressionExpression2.Neutral => "neutral",
                CreateTalkRequestConfigDriverExpressionsExpressionExpression2.Serious => "serious",
                CreateTalkRequestConfigDriverExpressionsExpressionExpression2.Surprise => "surprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTalkRequestConfigDriverExpressionsExpressionExpression2? ToEnum(string value)
        {
            return value switch
            {
                "happy" => CreateTalkRequestConfigDriverExpressionsExpressionExpression2.Happy,
                "neutral" => CreateTalkRequestConfigDriverExpressionsExpressionExpression2.Neutral,
                "serious" => CreateTalkRequestConfigDriverExpressionsExpressionExpression2.Serious,
                "surprise" => CreateTalkRequestConfigDriverExpressionsExpressionExpression2.Surprise,
                _ => null,
            };
        }
    }
}
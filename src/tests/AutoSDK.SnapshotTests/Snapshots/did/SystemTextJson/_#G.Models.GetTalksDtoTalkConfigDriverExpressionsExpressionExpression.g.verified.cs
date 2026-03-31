//HintName: G.Models.GetTalksDtoTalkConfigDriverExpressionsExpressionExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The expression to use
    /// </summary>
    public enum GetTalksDtoTalkConfigDriverExpressionsExpressionExpression
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
    public static class GetTalksDtoTalkConfigDriverExpressionsExpressionExpressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTalksDtoTalkConfigDriverExpressionsExpressionExpression value)
        {
            return value switch
            {
                GetTalksDtoTalkConfigDriverExpressionsExpressionExpression.Happy => "happy",
                GetTalksDtoTalkConfigDriverExpressionsExpressionExpression.Neutral => "neutral",
                GetTalksDtoTalkConfigDriverExpressionsExpressionExpression.Serious => "serious",
                GetTalksDtoTalkConfigDriverExpressionsExpressionExpression.Surprise => "surprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTalksDtoTalkConfigDriverExpressionsExpressionExpression? ToEnum(string value)
        {
            return value switch
            {
                "happy" => GetTalksDtoTalkConfigDriverExpressionsExpressionExpression.Happy,
                "neutral" => GetTalksDtoTalkConfigDriverExpressionsExpressionExpression.Neutral,
                "serious" => GetTalksDtoTalkConfigDriverExpressionsExpressionExpression.Serious,
                "surprise" => GetTalksDtoTalkConfigDriverExpressionsExpressionExpression.Surprise,
                _ => null,
            };
        }
    }
}
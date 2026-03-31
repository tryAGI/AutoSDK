//HintName: G.Models.GetTalksResponseTalkConfigDriverExpressionsExpressionExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The expression to use
    /// </summary>
    public enum GetTalksResponseTalkConfigDriverExpressionsExpressionExpression
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
    public static class GetTalksResponseTalkConfigDriverExpressionsExpressionExpressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTalksResponseTalkConfigDriverExpressionsExpressionExpression value)
        {
            return value switch
            {
                GetTalksResponseTalkConfigDriverExpressionsExpressionExpression.Happy => "happy",
                GetTalksResponseTalkConfigDriverExpressionsExpressionExpression.Neutral => "neutral",
                GetTalksResponseTalkConfigDriverExpressionsExpressionExpression.Serious => "serious",
                GetTalksResponseTalkConfigDriverExpressionsExpressionExpression.Surprise => "surprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTalksResponseTalkConfigDriverExpressionsExpressionExpression? ToEnum(string value)
        {
            return value switch
            {
                "happy" => GetTalksResponseTalkConfigDriverExpressionsExpressionExpression.Happy,
                "neutral" => GetTalksResponseTalkConfigDriverExpressionsExpressionExpression.Neutral,
                "serious" => GetTalksResponseTalkConfigDriverExpressionsExpressionExpression.Serious,
                "surprise" => GetTalksResponseTalkConfigDriverExpressionsExpressionExpression.Surprise,
                _ => null,
            };
        }
    }
}
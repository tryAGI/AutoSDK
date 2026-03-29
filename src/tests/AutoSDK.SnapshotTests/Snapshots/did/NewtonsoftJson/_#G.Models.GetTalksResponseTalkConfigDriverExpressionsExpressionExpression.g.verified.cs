//HintName: G.Models.GetTalksResponseTalkConfigDriverExpressionsExpressionExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The expression to use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTalksResponseTalkConfigDriverExpressionsExpressionExpression
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="happy")]
        Happy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="serious")]
        Serious,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="surprise")]
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
//HintName: G.Models.GetTalkResponseConfigDriverExpressionsExpressionExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The expression to use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTalkResponseConfigDriverExpressionsExpressionExpression
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
    public static class GetTalkResponseConfigDriverExpressionsExpressionExpressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTalkResponseConfigDriverExpressionsExpressionExpression value)
        {
            return value switch
            {
                GetTalkResponseConfigDriverExpressionsExpressionExpression.Happy => "happy",
                GetTalkResponseConfigDriverExpressionsExpressionExpression.Neutral => "neutral",
                GetTalkResponseConfigDriverExpressionsExpressionExpression.Serious => "serious",
                GetTalkResponseConfigDriverExpressionsExpressionExpression.Surprise => "surprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTalkResponseConfigDriverExpressionsExpressionExpression? ToEnum(string value)
        {
            return value switch
            {
                "happy" => GetTalkResponseConfigDriverExpressionsExpressionExpression.Happy,
                "neutral" => GetTalkResponseConfigDriverExpressionsExpressionExpression.Neutral,
                "serious" => GetTalkResponseConfigDriverExpressionsExpressionExpression.Serious,
                "surprise" => GetTalkResponseConfigDriverExpressionsExpressionExpression.Surprise,
                _ => null,
            };
        }
    }
}
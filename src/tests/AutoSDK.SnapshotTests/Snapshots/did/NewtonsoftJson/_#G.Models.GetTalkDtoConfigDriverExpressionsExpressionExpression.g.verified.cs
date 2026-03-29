//HintName: G.Models.GetTalkDtoConfigDriverExpressionsExpressionExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The expression to use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTalkDtoConfigDriverExpressionsExpressionExpression
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
    public static class GetTalkDtoConfigDriverExpressionsExpressionExpressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTalkDtoConfigDriverExpressionsExpressionExpression value)
        {
            return value switch
            {
                GetTalkDtoConfigDriverExpressionsExpressionExpression.Happy => "happy",
                GetTalkDtoConfigDriverExpressionsExpressionExpression.Neutral => "neutral",
                GetTalkDtoConfigDriverExpressionsExpressionExpression.Serious => "serious",
                GetTalkDtoConfigDriverExpressionsExpressionExpression.Surprise => "surprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTalkDtoConfigDriverExpressionsExpressionExpression? ToEnum(string value)
        {
            return value switch
            {
                "happy" => GetTalkDtoConfigDriverExpressionsExpressionExpression.Happy,
                "neutral" => GetTalkDtoConfigDriverExpressionsExpressionExpression.Neutral,
                "serious" => GetTalkDtoConfigDriverExpressionsExpressionExpression.Serious,
                "surprise" => GetTalkDtoConfigDriverExpressionsExpressionExpression.Surprise,
                _ => null,
            };
        }
    }
}
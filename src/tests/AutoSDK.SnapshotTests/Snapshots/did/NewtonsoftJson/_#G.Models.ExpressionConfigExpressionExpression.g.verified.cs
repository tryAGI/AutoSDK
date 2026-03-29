//HintName: G.Models.ExpressionConfigExpressionExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The expression to use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExpressionConfigExpressionExpression
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
    public static class ExpressionConfigExpressionExpressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExpressionConfigExpressionExpression value)
        {
            return value switch
            {
                ExpressionConfigExpressionExpression.Happy => "happy",
                ExpressionConfigExpressionExpression.Neutral => "neutral",
                ExpressionConfigExpressionExpression.Serious => "serious",
                ExpressionConfigExpressionExpression.Surprise => "surprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExpressionConfigExpressionExpression? ToEnum(string value)
        {
            return value switch
            {
                "happy" => ExpressionConfigExpressionExpression.Happy,
                "neutral" => ExpressionConfigExpressionExpression.Neutral,
                "serious" => ExpressionConfigExpressionExpression.Serious,
                "surprise" => ExpressionConfigExpressionExpression.Surprise,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.TalksConfigDriverExpressionsExpressionExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The expression to use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TalksConfigDriverExpressionsExpressionExpression
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
    public static class TalksConfigDriverExpressionsExpressionExpressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TalksConfigDriverExpressionsExpressionExpression value)
        {
            return value switch
            {
                TalksConfigDriverExpressionsExpressionExpression.Happy => "happy",
                TalksConfigDriverExpressionsExpressionExpression.Neutral => "neutral",
                TalksConfigDriverExpressionsExpressionExpression.Serious => "serious",
                TalksConfigDriverExpressionsExpressionExpression.Surprise => "surprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TalksConfigDriverExpressionsExpressionExpression? ToEnum(string value)
        {
            return value switch
            {
                "happy" => TalksConfigDriverExpressionsExpressionExpression.Happy,
                "neutral" => TalksConfigDriverExpressionsExpressionExpression.Neutral,
                "serious" => TalksConfigDriverExpressionsExpressionExpression.Serious,
                "surprise" => TalksConfigDriverExpressionsExpressionExpression.Surprise,
                _ => null,
            };
        }
    }
}
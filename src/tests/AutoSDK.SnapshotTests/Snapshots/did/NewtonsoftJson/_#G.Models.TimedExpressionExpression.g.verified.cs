//HintName: G.Models.TimedExpressionExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The expression to use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TimedExpressionExpression
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
    public static class TimedExpressionExpressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TimedExpressionExpression value)
        {
            return value switch
            {
                TimedExpressionExpression.Happy => "happy",
                TimedExpressionExpression.Neutral => "neutral",
                TimedExpressionExpression.Serious => "serious",
                TimedExpressionExpression.Surprise => "surprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TimedExpressionExpression? ToEnum(string value)
        {
            return value switch
            {
                "happy" => TimedExpressionExpression.Happy,
                "neutral" => TimedExpressionExpression.Neutral,
                "serious" => TimedExpressionExpression.Serious,
                "surprise" => TimedExpressionExpression.Surprise,
                _ => null,
            };
        }
    }
}
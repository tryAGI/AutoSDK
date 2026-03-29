//HintName: G.Models.DeleteTalkResponseConfigDriverExpressionsExpressionExpression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The expression to use
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteTalkResponseConfigDriverExpressionsExpressionExpression
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
    public static class DeleteTalkResponseConfigDriverExpressionsExpressionExpressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteTalkResponseConfigDriverExpressionsExpressionExpression value)
        {
            return value switch
            {
                DeleteTalkResponseConfigDriverExpressionsExpressionExpression.Happy => "happy",
                DeleteTalkResponseConfigDriverExpressionsExpressionExpression.Neutral => "neutral",
                DeleteTalkResponseConfigDriverExpressionsExpressionExpression.Serious => "serious",
                DeleteTalkResponseConfigDriverExpressionsExpressionExpression.Surprise => "surprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteTalkResponseConfigDriverExpressionsExpressionExpression? ToEnum(string value)
        {
            return value switch
            {
                "happy" => DeleteTalkResponseConfigDriverExpressionsExpressionExpression.Happy,
                "neutral" => DeleteTalkResponseConfigDriverExpressionsExpressionExpression.Neutral,
                "serious" => DeleteTalkResponseConfigDriverExpressionsExpressionExpression.Serious,
                "surprise" => DeleteTalkResponseConfigDriverExpressionsExpressionExpression.Surprise,
                _ => null,
            };
        }
    }
}
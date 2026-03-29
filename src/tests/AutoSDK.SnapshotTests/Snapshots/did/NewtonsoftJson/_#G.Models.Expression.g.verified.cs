//HintName: G.Models.Expression.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Expression
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
    public static class ExpressionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Expression value)
        {
            return value switch
            {
                Expression.Happy => "happy",
                Expression.Neutral => "neutral",
                Expression.Serious => "serious",
                Expression.Surprise => "surprise",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Expression? ToEnum(string value)
        {
            return value switch
            {
                "happy" => Expression.Happy,
                "neutral" => Expression.Neutral,
                "serious" => Expression.Serious,
                "surprise" => Expression.Surprise,
                _ => null,
            };
        }
    }
}
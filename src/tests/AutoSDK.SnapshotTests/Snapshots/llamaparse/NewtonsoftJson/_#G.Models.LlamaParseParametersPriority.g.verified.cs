//HintName: G.Models.LlamaParseParametersPriority.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LlamaParseParametersPriority
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="critical")]
        Critical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="high")]
        High,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="low")]
        Low,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="medium")]
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlamaParseParametersPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlamaParseParametersPriority value)
        {
            return value switch
            {
                LlamaParseParametersPriority.Critical => "critical",
                LlamaParseParametersPriority.High => "high",
                LlamaParseParametersPriority.Low => "low",
                LlamaParseParametersPriority.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlamaParseParametersPriority? ToEnum(string value)
        {
            return value switch
            {
                "critical" => LlamaParseParametersPriority.Critical,
                "high" => LlamaParseParametersPriority.High,
                "low" => LlamaParseParametersPriority.Low,
                "medium" => LlamaParseParametersPriority.Medium,
                _ => null,
            };
        }
    }
}
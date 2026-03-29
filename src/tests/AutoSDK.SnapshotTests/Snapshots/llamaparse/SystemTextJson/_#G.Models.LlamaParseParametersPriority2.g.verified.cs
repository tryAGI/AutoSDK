//HintName: G.Models.LlamaParseParametersPriority2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlamaParseParametersPriority2
    {
        /// <summary>
        /// 
        /// </summary>
        Critical,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlamaParseParametersPriority2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlamaParseParametersPriority2 value)
        {
            return value switch
            {
                LlamaParseParametersPriority2.Critical => "critical",
                LlamaParseParametersPriority2.High => "high",
                LlamaParseParametersPriority2.Low => "low",
                LlamaParseParametersPriority2.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlamaParseParametersPriority2? ToEnum(string value)
        {
            return value switch
            {
                "critical" => LlamaParseParametersPriority2.Critical,
                "high" => LlamaParseParametersPriority2.High,
                "low" => LlamaParseParametersPriority2.Low,
                "medium" => LlamaParseParametersPriority2.Medium,
                _ => null,
            };
        }
    }
}
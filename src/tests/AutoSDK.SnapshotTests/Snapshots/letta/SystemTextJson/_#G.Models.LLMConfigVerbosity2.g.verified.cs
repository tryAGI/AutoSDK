//HintName: G.Models.LLMConfigVerbosity2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMConfigVerbosity2
    {
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
    public static class LLMConfigVerbosity2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigVerbosity2 value)
        {
            return value switch
            {
                LLMConfigVerbosity2.High => "high",
                LLMConfigVerbosity2.Low => "low",
                LLMConfigVerbosity2.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigVerbosity2? ToEnum(string value)
        {
            return value switch
            {
                "high" => LLMConfigVerbosity2.High,
                "low" => LLMConfigVerbosity2.Low,
                "medium" => LLMConfigVerbosity2.Medium,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.LLMConfigEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMConfigEffort
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
        Max,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigEffort value)
        {
            return value switch
            {
                LLMConfigEffort.High => "high",
                LLMConfigEffort.Low => "low",
                LLMConfigEffort.Max => "max",
                LLMConfigEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => LLMConfigEffort.High,
                "low" => LLMConfigEffort.Low,
                "max" => LLMConfigEffort.Max,
                "medium" => LLMConfigEffort.Medium,
                _ => null,
            };
        }
    }
}
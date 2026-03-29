//HintName: G.Models.LLMRequestBodyVerbosity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LLMRequestBodyVerbosity
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
    public static class LLMRequestBodyVerbosityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMRequestBodyVerbosity value)
        {
            return value switch
            {
                LLMRequestBodyVerbosity.High => "high",
                LLMRequestBodyVerbosity.Low => "low",
                LLMRequestBodyVerbosity.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMRequestBodyVerbosity? ToEnum(string value)
        {
            return value switch
            {
                "high" => LLMRequestBodyVerbosity.High,
                "low" => LLMRequestBodyVerbosity.Low,
                "medium" => LLMRequestBodyVerbosity.Medium,
                _ => null,
            };
        }
    }
}
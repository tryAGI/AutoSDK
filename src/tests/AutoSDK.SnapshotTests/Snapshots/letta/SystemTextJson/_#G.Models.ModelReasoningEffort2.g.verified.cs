//HintName: G.Models.ModelReasoningEffort2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelReasoningEffort2
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
        /// <summary>
        /// 
        /// </summary>
        Minimal,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelReasoningEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelReasoningEffort2 value)
        {
            return value switch
            {
                ModelReasoningEffort2.High => "high",
                ModelReasoningEffort2.Low => "low",
                ModelReasoningEffort2.Medium => "medium",
                ModelReasoningEffort2.Minimal => "minimal",
                ModelReasoningEffort2.None => "none",
                ModelReasoningEffort2.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelReasoningEffort2? ToEnum(string value)
        {
            return value switch
            {
                "high" => ModelReasoningEffort2.High,
                "low" => ModelReasoningEffort2.Low,
                "medium" => ModelReasoningEffort2.Medium,
                "minimal" => ModelReasoningEffort2.Minimal,
                "none" => ModelReasoningEffort2.None,
                "xhigh" => ModelReasoningEffort2.Xhigh,
                _ => null,
            };
        }
    }
}
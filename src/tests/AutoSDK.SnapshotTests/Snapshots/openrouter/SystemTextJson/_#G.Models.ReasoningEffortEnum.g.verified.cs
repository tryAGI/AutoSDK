//HintName: G.Models.ReasoningEffortEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReasoningEffortEnum
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
    public static class ReasoningEffortEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningEffortEnum value)
        {
            return value switch
            {
                ReasoningEffortEnum.High => "high",
                ReasoningEffortEnum.Low => "low",
                ReasoningEffortEnum.Medium => "medium",
                ReasoningEffortEnum.Minimal => "minimal",
                ReasoningEffortEnum.None => "none",
                ReasoningEffortEnum.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningEffortEnum? ToEnum(string value)
        {
            return value switch
            {
                "high" => ReasoningEffortEnum.High,
                "low" => ReasoningEffortEnum.Low,
                "medium" => ReasoningEffortEnum.Medium,
                "minimal" => ReasoningEffortEnum.Minimal,
                "none" => ReasoningEffortEnum.None,
                "xhigh" => ReasoningEffortEnum.Xhigh,
                _ => null,
            };
        }
    }
}
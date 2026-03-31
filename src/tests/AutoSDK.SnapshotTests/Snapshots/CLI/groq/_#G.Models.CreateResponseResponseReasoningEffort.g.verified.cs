//HintName: G.Models.CreateResponseResponseReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reasoning effort level used.
    /// </summary>
    public enum CreateResponseResponseReasoningEffort
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
    public static class CreateResponseResponseReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseResponseReasoningEffort value)
        {
            return value switch
            {
                CreateResponseResponseReasoningEffort.High => "high",
                CreateResponseResponseReasoningEffort.Low => "low",
                CreateResponseResponseReasoningEffort.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseResponseReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateResponseResponseReasoningEffort.High,
                "low" => CreateResponseResponseReasoningEffort.Low,
                "medium" => CreateResponseResponseReasoningEffort.Medium,
                _ => null,
            };
        }
    }
}
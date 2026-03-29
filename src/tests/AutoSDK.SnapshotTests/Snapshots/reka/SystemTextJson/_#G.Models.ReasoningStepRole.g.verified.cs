//HintName: G.Models.ReasoningStepRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// "assistant" for agent reasoning, "tool" for tool execution results.
    /// </summary>
    public enum ReasoningStepRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningStepRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningStepRole value)
        {
            return value switch
            {
                ReasoningStepRole.Assistant => "assistant",
                ReasoningStepRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningStepRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ReasoningStepRole.Assistant,
                "tool" => ReasoningStepRole.Tool,
                _ => null,
            };
        }
    }
}
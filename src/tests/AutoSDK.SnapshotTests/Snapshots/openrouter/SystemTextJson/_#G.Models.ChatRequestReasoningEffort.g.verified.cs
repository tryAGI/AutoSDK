//HintName: G.Models.ChatRequestReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Constrains effort on reasoning for reasoning models
    /// </summary>
    public enum ChatRequestReasoningEffort
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
    public static class ChatRequestReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestReasoningEffort value)
        {
            return value switch
            {
                ChatRequestReasoningEffort.High => "high",
                ChatRequestReasoningEffort.Low => "low",
                ChatRequestReasoningEffort.Medium => "medium",
                ChatRequestReasoningEffort.Minimal => "minimal",
                ChatRequestReasoningEffort.None => "none",
                ChatRequestReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatRequestReasoningEffort.High,
                "low" => ChatRequestReasoningEffort.Low,
                "medium" => ChatRequestReasoningEffort.Medium,
                "minimal" => ChatRequestReasoningEffort.Minimal,
                "none" => ChatRequestReasoningEffort.None,
                "xhigh" => ChatRequestReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}
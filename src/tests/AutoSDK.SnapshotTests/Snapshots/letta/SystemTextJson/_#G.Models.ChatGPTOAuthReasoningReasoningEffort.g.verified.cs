//HintName: G.Models.ChatGPTOAuthReasoningReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reasoning effort level for GPT-5.x and o-series models.<br/>
    /// Default Value: medium
    /// </summary>
    public enum ChatGPTOAuthReasoningReasoningEffort
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
        None,
        /// <summary>
        /// 
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatGPTOAuthReasoningReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatGPTOAuthReasoningReasoningEffort value)
        {
            return value switch
            {
                ChatGPTOAuthReasoningReasoningEffort.High => "high",
                ChatGPTOAuthReasoningReasoningEffort.Low => "low",
                ChatGPTOAuthReasoningReasoningEffort.Medium => "medium",
                ChatGPTOAuthReasoningReasoningEffort.None => "none",
                ChatGPTOAuthReasoningReasoningEffort.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatGPTOAuthReasoningReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => ChatGPTOAuthReasoningReasoningEffort.High,
                "low" => ChatGPTOAuthReasoningReasoningEffort.Low,
                "medium" => ChatGPTOAuthReasoningReasoningEffort.Medium,
                "none" => ChatGPTOAuthReasoningReasoningEffort.None,
                "xhigh" => ChatGPTOAuthReasoningReasoningEffort.Xhigh,
                _ => null,
            };
        }
    }
}
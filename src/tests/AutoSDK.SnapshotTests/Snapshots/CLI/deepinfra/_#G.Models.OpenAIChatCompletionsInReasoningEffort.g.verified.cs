//HintName: G.Models.OpenAIChatCompletionsInReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAIChatCompletionsInReasoningEffort
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIChatCompletionsInReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIChatCompletionsInReasoningEffort value)
        {
            return value switch
            {
                OpenAIChatCompletionsInReasoningEffort.High => "high",
                OpenAIChatCompletionsInReasoningEffort.Low => "low",
                OpenAIChatCompletionsInReasoningEffort.Medium => "medium",
                OpenAIChatCompletionsInReasoningEffort.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIChatCompletionsInReasoningEffort? ToEnum(string value)
        {
            return value switch
            {
                "high" => OpenAIChatCompletionsInReasoningEffort.High,
                "low" => OpenAIChatCompletionsInReasoningEffort.Low,
                "medium" => OpenAIChatCompletionsInReasoningEffort.Medium,
                "none" => OpenAIChatCompletionsInReasoningEffort.None,
                _ => null,
            };
        }
    }
}
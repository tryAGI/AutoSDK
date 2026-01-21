//HintName: G.Models.OpenAIChatCompletionsInReasoningEffort2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenAIChatCompletionsInReasoningEffort2
    {
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
        High,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIChatCompletionsInReasoningEffort2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIChatCompletionsInReasoningEffort2 value)
        {
            return value switch
            {
                OpenAIChatCompletionsInReasoningEffort2.Low => "low",
                OpenAIChatCompletionsInReasoningEffort2.Medium => "medium",
                OpenAIChatCompletionsInReasoningEffort2.High => "high",
                OpenAIChatCompletionsInReasoningEffort2.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIChatCompletionsInReasoningEffort2? ToEnum(string value)
        {
            return value switch
            {
                "low" => OpenAIChatCompletionsInReasoningEffort2.Low,
                "medium" => OpenAIChatCompletionsInReasoningEffort2.Medium,
                "high" => OpenAIChatCompletionsInReasoningEffort2.High,
                "none" => OpenAIChatCompletionsInReasoningEffort2.None,
                _ => null,
            };
        }
    }
}
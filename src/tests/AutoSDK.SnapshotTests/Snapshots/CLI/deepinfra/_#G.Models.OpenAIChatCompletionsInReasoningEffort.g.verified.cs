//HintName: G.Models.OpenAIChatCompletionsInReasoningEffort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Constrains effort on reasoning for reasoning models. Currently supported values are none, low, medium, and high. Reducing reasoning effort can result in faster responses and fewer tokens used on reasoning in a response. Setting to none disables reasoning entirely if the model supports.
    /// </summary>
    public enum OpenAIChatCompletionsInReasoningEffort
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
    public static class OpenAIChatCompletionsInReasoningEffortExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIChatCompletionsInReasoningEffort value)
        {
            return value switch
            {
                OpenAIChatCompletionsInReasoningEffort.Low => "low",
                OpenAIChatCompletionsInReasoningEffort.Medium => "medium",
                OpenAIChatCompletionsInReasoningEffort.High => "high",
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
                "low" => OpenAIChatCompletionsInReasoningEffort.Low,
                "medium" => OpenAIChatCompletionsInReasoningEffort.Medium,
                "high" => OpenAIChatCompletionsInReasoningEffort.High,
                "none" => OpenAIChatCompletionsInReasoningEffort.None,
                _ => null,
            };
        }
    }
}
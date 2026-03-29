//HintName: G.Models.Parameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Parameter
    {
        /// <summary>
        /// 
        /// </summary>
        FrequencyPenalty,
        /// <summary>
        /// 
        /// </summary>
        IncludeReasoning,
        /// <summary>
        /// 
        /// </summary>
        LogitBias,
        /// <summary>
        /// 
        /// </summary>
        Logprobs,
        /// <summary>
        /// 
        /// </summary>
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        MinP,
        /// <summary>
        /// 
        /// </summary>
        ParallelToolCalls,
        /// <summary>
        /// 
        /// </summary>
        PresencePenalty,
        /// <summary>
        /// 
        /// </summary>
        Reasoning,
        /// <summary>
        /// 
        /// </summary>
        ReasoningEffort,
        /// <summary>
        /// 
        /// </summary>
        RepetitionPenalty,
        /// <summary>
        /// 
        /// </summary>
        ResponseFormat,
        /// <summary>
        /// 
        /// </summary>
        Seed,
        /// <summary>
        /// 
        /// </summary>
        Stop,
        /// <summary>
        /// 
        /// </summary>
        StructuredOutputs,
        /// <summary>
        /// 
        /// </summary>
        Temperature,
        /// <summary>
        /// 
        /// </summary>
        ToolChoice,
        /// <summary>
        /// 
        /// </summary>
        Tools,
        /// <summary>
        /// 
        /// </summary>
        TopA,
        /// <summary>
        /// 
        /// </summary>
        TopK,
        /// <summary>
        /// 
        /// </summary>
        TopLogprobs,
        /// <summary>
        /// 
        /// </summary>
        TopP,
        /// <summary>
        /// 
        /// </summary>
        Verbosity,
        /// <summary>
        /// 
        /// </summary>
        WebSearchOptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ParameterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Parameter value)
        {
            return value switch
            {
                Parameter.FrequencyPenalty => "frequency_penalty",
                Parameter.IncludeReasoning => "include_reasoning",
                Parameter.LogitBias => "logit_bias",
                Parameter.Logprobs => "logprobs",
                Parameter.MaxTokens => "max_tokens",
                Parameter.MinP => "min_p",
                Parameter.ParallelToolCalls => "parallel_tool_calls",
                Parameter.PresencePenalty => "presence_penalty",
                Parameter.Reasoning => "reasoning",
                Parameter.ReasoningEffort => "reasoning_effort",
                Parameter.RepetitionPenalty => "repetition_penalty",
                Parameter.ResponseFormat => "response_format",
                Parameter.Seed => "seed",
                Parameter.Stop => "stop",
                Parameter.StructuredOutputs => "structured_outputs",
                Parameter.Temperature => "temperature",
                Parameter.ToolChoice => "tool_choice",
                Parameter.Tools => "tools",
                Parameter.TopA => "top_a",
                Parameter.TopK => "top_k",
                Parameter.TopLogprobs => "top_logprobs",
                Parameter.TopP => "top_p",
                Parameter.Verbosity => "verbosity",
                Parameter.WebSearchOptions => "web_search_options",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Parameter? ToEnum(string value)
        {
            return value switch
            {
                "frequency_penalty" => Parameter.FrequencyPenalty,
                "include_reasoning" => Parameter.IncludeReasoning,
                "logit_bias" => Parameter.LogitBias,
                "logprobs" => Parameter.Logprobs,
                "max_tokens" => Parameter.MaxTokens,
                "min_p" => Parameter.MinP,
                "parallel_tool_calls" => Parameter.ParallelToolCalls,
                "presence_penalty" => Parameter.PresencePenalty,
                "reasoning" => Parameter.Reasoning,
                "reasoning_effort" => Parameter.ReasoningEffort,
                "repetition_penalty" => Parameter.RepetitionPenalty,
                "response_format" => Parameter.ResponseFormat,
                "seed" => Parameter.Seed,
                "stop" => Parameter.Stop,
                "structured_outputs" => Parameter.StructuredOutputs,
                "temperature" => Parameter.Temperature,
                "tool_choice" => Parameter.ToolChoice,
                "tools" => Parameter.Tools,
                "top_a" => Parameter.TopA,
                "top_k" => Parameter.TopK,
                "top_logprobs" => Parameter.TopLogprobs,
                "top_p" => Parameter.TopP,
                "verbosity" => Parameter.Verbosity,
                "web_search_options" => Parameter.WebSearchOptions,
                _ => null,
            };
        }
    }
}
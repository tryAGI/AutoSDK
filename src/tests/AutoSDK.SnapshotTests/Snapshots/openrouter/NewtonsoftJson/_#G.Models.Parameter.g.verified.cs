//HintName: G.Models.Parameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Parameter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="frequency_penalty")]
        FrequencyPenalty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="include_reasoning")]
        IncludeReasoning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logit_bias")]
        LogitBias,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logprobs")]
        Logprobs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_tokens")]
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="min_p")]
        MinP,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parallel_tool_calls")]
        ParallelToolCalls,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="presence_penalty")]
        PresencePenalty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reasoning")]
        Reasoning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reasoning_effort")]
        ReasoningEffort,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="repetition_penalty")]
        RepetitionPenalty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="response_format")]
        ResponseFormat,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="seed")]
        Seed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stop")]
        Stop,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="structured_outputs")]
        StructuredOutputs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="temperature")]
        Temperature,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_choice")]
        ToolChoice,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tools")]
        Tools,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="top_a")]
        TopA,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="top_k")]
        TopK,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="top_logprobs")]
        TopLogprobs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="top_p")]
        TopP,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="verbosity")]
        Verbosity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="web_search_options")]
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
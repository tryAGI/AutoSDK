//HintName: G.Models.StandardParameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StandardParameter
    {
        /// <summary>
        /// 
        /// </summary>
        FrequencyPenalty,
        /// <summary>
        /// 
        /// </summary>
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        Functions,
        /// <summary>
        /// 
        /// </summary>
        IncludeReasoning,
        /// <summary>
        /// 
        /// </summary>
        JsonMode,
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
        MaxCompletionTokens,
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
        N,
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
        Stream,
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
        Thinking,
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
        Truncate,
        /// <summary>
        /// 
        /// </summary>
        Verbosity,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StandardParameterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StandardParameter value)
        {
            return value switch
            {
                StandardParameter.FrequencyPenalty => "frequency_penalty",
                StandardParameter.FunctionCall => "function_call",
                StandardParameter.Functions => "functions",
                StandardParameter.IncludeReasoning => "include_reasoning",
                StandardParameter.JsonMode => "json_mode",
                StandardParameter.LogitBias => "logit_bias",
                StandardParameter.Logprobs => "logprobs",
                StandardParameter.MaxCompletionTokens => "max_completion_tokens",
                StandardParameter.MaxTokens => "max_tokens",
                StandardParameter.MinP => "min_p",
                StandardParameter.N => "n",
                StandardParameter.PresencePenalty => "presence_penalty",
                StandardParameter.Reasoning => "reasoning",
                StandardParameter.RepetitionPenalty => "repetition_penalty",
                StandardParameter.ResponseFormat => "response_format",
                StandardParameter.Seed => "seed",
                StandardParameter.Stop => "stop",
                StandardParameter.Stream => "stream",
                StandardParameter.StructuredOutputs => "structured_outputs",
                StandardParameter.Temperature => "temperature",
                StandardParameter.Thinking => "thinking",
                StandardParameter.ToolChoice => "tool_choice",
                StandardParameter.Tools => "tools",
                StandardParameter.TopK => "top_k",
                StandardParameter.TopLogprobs => "top_logprobs",
                StandardParameter.TopP => "top_p",
                StandardParameter.Truncate => "truncate",
                StandardParameter.Verbosity => "verbosity",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StandardParameter? ToEnum(string value)
        {
            return value switch
            {
                "frequency_penalty" => StandardParameter.FrequencyPenalty,
                "function_call" => StandardParameter.FunctionCall,
                "functions" => StandardParameter.Functions,
                "include_reasoning" => StandardParameter.IncludeReasoning,
                "json_mode" => StandardParameter.JsonMode,
                "logit_bias" => StandardParameter.LogitBias,
                "logprobs" => StandardParameter.Logprobs,
                "max_completion_tokens" => StandardParameter.MaxCompletionTokens,
                "max_tokens" => StandardParameter.MaxTokens,
                "min_p" => StandardParameter.MinP,
                "n" => StandardParameter.N,
                "presence_penalty" => StandardParameter.PresencePenalty,
                "reasoning" => StandardParameter.Reasoning,
                "repetition_penalty" => StandardParameter.RepetitionPenalty,
                "response_format" => StandardParameter.ResponseFormat,
                "seed" => StandardParameter.Seed,
                "stop" => StandardParameter.Stop,
                "stream" => StandardParameter.Stream,
                "structured_outputs" => StandardParameter.StructuredOutputs,
                "temperature" => StandardParameter.Temperature,
                "thinking" => StandardParameter.Thinking,
                "tool_choice" => StandardParameter.ToolChoice,
                "tools" => StandardParameter.Tools,
                "top_k" => StandardParameter.TopK,
                "top_logprobs" => StandardParameter.TopLogprobs,
                "top_p" => StandardParameter.TopP,
                "truncate" => StandardParameter.Truncate,
                "verbosity" => StandardParameter.Verbosity,
                _ => null,
            };
        }
    }
}
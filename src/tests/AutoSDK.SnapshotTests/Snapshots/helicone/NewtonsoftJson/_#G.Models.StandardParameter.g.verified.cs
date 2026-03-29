//HintName: G.Models.StandardParameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StandardParameter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="frequency_penalty")]
        FrequencyPenalty,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function_call")]
        FunctionCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="functions")]
        Functions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="include_reasoning")]
        IncludeReasoning,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json_mode")]
        JsonMode,
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
        [global::System.Runtime.Serialization.EnumMember(Value="max_completion_tokens")]
        MaxCompletionTokens,
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
        [global::System.Runtime.Serialization.EnumMember(Value="n")]
        N,
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
        [global::System.Runtime.Serialization.EnumMember(Value="stream")]
        Stream,
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
        [global::System.Runtime.Serialization.EnumMember(Value="thinking")]
        Thinking,
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
        [global::System.Runtime.Serialization.EnumMember(Value="truncate")]
        Truncate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="verbosity")]
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
//HintName: G.Models.StopReasonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StopReasonType
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        ContextWindowOverflowInSystemPrompt,
        /// <summary>
        /// 
        /// </summary>
        EndTurn,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        InsufficientCredits,
        /// <summary>
        /// 
        /// </summary>
        InvalidLlmResponse,
        /// <summary>
        /// 
        /// </summary>
        InvalidToolCall,
        /// <summary>
        /// 
        /// </summary>
        LlmApiError,
        /// <summary>
        /// 
        /// </summary>
        MaxSteps,
        /// <summary>
        /// 
        /// </summary>
        MaxTokensExceeded,
        /// <summary>
        /// 
        /// </summary>
        NoToolCall,
        /// <summary>
        /// 
        /// </summary>
        RequiresApproval,
        /// <summary>
        /// 
        /// </summary>
        ToolRule,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StopReasonTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StopReasonType value)
        {
            return value switch
            {
                StopReasonType.Cancelled => "cancelled",
                StopReasonType.ContextWindowOverflowInSystemPrompt => "context_window_overflow_in_system_prompt",
                StopReasonType.EndTurn => "end_turn",
                StopReasonType.Error => "error",
                StopReasonType.InsufficientCredits => "insufficient_credits",
                StopReasonType.InvalidLlmResponse => "invalid_llm_response",
                StopReasonType.InvalidToolCall => "invalid_tool_call",
                StopReasonType.LlmApiError => "llm_api_error",
                StopReasonType.MaxSteps => "max_steps",
                StopReasonType.MaxTokensExceeded => "max_tokens_exceeded",
                StopReasonType.NoToolCall => "no_tool_call",
                StopReasonType.RequiresApproval => "requires_approval",
                StopReasonType.ToolRule => "tool_rule",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StopReasonType? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => StopReasonType.Cancelled,
                "context_window_overflow_in_system_prompt" => StopReasonType.ContextWindowOverflowInSystemPrompt,
                "end_turn" => StopReasonType.EndTurn,
                "error" => StopReasonType.Error,
                "insufficient_credits" => StopReasonType.InsufficientCredits,
                "invalid_llm_response" => StopReasonType.InvalidLlmResponse,
                "invalid_tool_call" => StopReasonType.InvalidToolCall,
                "llm_api_error" => StopReasonType.LlmApiError,
                "max_steps" => StopReasonType.MaxSteps,
                "max_tokens_exceeded" => StopReasonType.MaxTokensExceeded,
                "no_tool_call" => StopReasonType.NoToolCall,
                "requires_approval" => StopReasonType.RequiresApproval,
                "tool_rule" => StopReasonType.ToolRule,
                _ => null,
            };
        }
    }
}
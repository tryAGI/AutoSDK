//HintName: G.Models.StopReasonType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StopReasonType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="context_window_overflow_in_system_prompt")]
        ContextWindowOverflowInSystemPrompt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="end_turn")]
        EndTurn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="insufficient_credits")]
        InsufficientCredits,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_llm_response")]
        InvalidLlmResponse,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invalid_tool_call")]
        InvalidToolCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm_api_error")]
        LlmApiError,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_steps")]
        MaxSteps,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="max_tokens_exceeded")]
        MaxTokensExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="no_tool_call")]
        NoToolCall,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requires_approval")]
        RequiresApproval,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_rule")]
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
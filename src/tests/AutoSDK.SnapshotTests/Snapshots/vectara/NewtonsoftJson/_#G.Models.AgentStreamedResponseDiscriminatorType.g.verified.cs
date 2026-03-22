//HintName: G.Models.AgentStreamedResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentStreamedResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="compaction")]
        Compaction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="compaction_started")]
        CompactionStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="context_consumed")]
        ContextConsumed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="context_limit_exceeded")]
        ContextLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="end")]
        End,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_read")]
        ImageRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_message")]
        InputMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session_interrupted")]
        SessionInterrupted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="step_transition")]
        StepTransition,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="step_transition_limit_exceeded")]
        StepTransitionLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="streaming_agent_output")]
        StreamingAgentOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="streaming_agent_output_end")]
        StreamingAgentOutputEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="streaming_thinking")]
        StreamingThinking,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="streaming_thinking_end")]
        StreamingThinkingEnd,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="structured_output")]
        StructuredOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_input")]
        ToolInput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool_output")]
        ToolOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentStreamedResponseDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentStreamedResponseDiscriminatorType value)
        {
            return value switch
            {
                AgentStreamedResponseDiscriminatorType.Compaction => "compaction",
                AgentStreamedResponseDiscriminatorType.CompactionStarted => "compaction_started",
                AgentStreamedResponseDiscriminatorType.ContextConsumed => "context_consumed",
                AgentStreamedResponseDiscriminatorType.ContextLimitExceeded => "context_limit_exceeded",
                AgentStreamedResponseDiscriminatorType.End => "end",
                AgentStreamedResponseDiscriminatorType.Error => "error",
                AgentStreamedResponseDiscriminatorType.ImageRead => "image_read",
                AgentStreamedResponseDiscriminatorType.InputMessage => "input_message",
                AgentStreamedResponseDiscriminatorType.SessionInterrupted => "session_interrupted",
                AgentStreamedResponseDiscriminatorType.StepTransition => "step_transition",
                AgentStreamedResponseDiscriminatorType.StepTransitionLimitExceeded => "step_transition_limit_exceeded",
                AgentStreamedResponseDiscriminatorType.StreamingAgentOutput => "streaming_agent_output",
                AgentStreamedResponseDiscriminatorType.StreamingAgentOutputEnd => "streaming_agent_output_end",
                AgentStreamedResponseDiscriminatorType.StreamingThinking => "streaming_thinking",
                AgentStreamedResponseDiscriminatorType.StreamingThinkingEnd => "streaming_thinking_end",
                AgentStreamedResponseDiscriminatorType.StructuredOutput => "structured_output",
                AgentStreamedResponseDiscriminatorType.ToolInput => "tool_input",
                AgentStreamedResponseDiscriminatorType.ToolOutput => "tool_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentStreamedResponseDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "compaction" => AgentStreamedResponseDiscriminatorType.Compaction,
                "compaction_started" => AgentStreamedResponseDiscriminatorType.CompactionStarted,
                "context_consumed" => AgentStreamedResponseDiscriminatorType.ContextConsumed,
                "context_limit_exceeded" => AgentStreamedResponseDiscriminatorType.ContextLimitExceeded,
                "end" => AgentStreamedResponseDiscriminatorType.End,
                "error" => AgentStreamedResponseDiscriminatorType.Error,
                "image_read" => AgentStreamedResponseDiscriminatorType.ImageRead,
                "input_message" => AgentStreamedResponseDiscriminatorType.InputMessage,
                "session_interrupted" => AgentStreamedResponseDiscriminatorType.SessionInterrupted,
                "step_transition" => AgentStreamedResponseDiscriminatorType.StepTransition,
                "step_transition_limit_exceeded" => AgentStreamedResponseDiscriminatorType.StepTransitionLimitExceeded,
                "streaming_agent_output" => AgentStreamedResponseDiscriminatorType.StreamingAgentOutput,
                "streaming_agent_output_end" => AgentStreamedResponseDiscriminatorType.StreamingAgentOutputEnd,
                "streaming_thinking" => AgentStreamedResponseDiscriminatorType.StreamingThinking,
                "streaming_thinking_end" => AgentStreamedResponseDiscriminatorType.StreamingThinkingEnd,
                "structured_output" => AgentStreamedResponseDiscriminatorType.StructuredOutput,
                "tool_input" => AgentStreamedResponseDiscriminatorType.ToolInput,
                "tool_output" => AgentStreamedResponseDiscriminatorType.ToolOutput,
                _ => null,
            };
        }
    }
}
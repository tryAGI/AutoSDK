//HintName: G.Models.AgentStreamedResponseDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentStreamedResponseDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InputMessage,
        /// <summary>
        /// 
        /// </summary>
        StreamingAgentOutput,
        /// <summary>
        /// 
        /// </summary>
        StreamingAgentOutputEnd,
        /// <summary>
        /// 
        /// </summary>
        StreamingThinking,
        /// <summary>
        /// 
        /// </summary>
        StreamingThinkingEnd,
        /// <summary>
        /// 
        /// </summary>
        ToolInput,
        /// <summary>
        /// 
        /// </summary>
        ToolOutput,
        /// <summary>
        /// 
        /// </summary>
        StructuredOutput,
        /// <summary>
        /// 
        /// </summary>
        ContextLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        StepTransitionLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        SessionInterrupted,
        /// <summary>
        /// 
        /// </summary>
        ImageRead,
        /// <summary>
        /// 
        /// </summary>
        StepTransition,
        /// <summary>
        /// 
        /// </summary>
        ContextConsumed,
        /// <summary>
        /// 
        /// </summary>
        CompactionStarted,
        /// <summary>
        /// 
        /// </summary>
        Compaction,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        End,
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
                AgentStreamedResponseDiscriminatorType.InputMessage => "input_message",
                AgentStreamedResponseDiscriminatorType.StreamingAgentOutput => "streaming_agent_output",
                AgentStreamedResponseDiscriminatorType.StreamingAgentOutputEnd => "streaming_agent_output_end",
                AgentStreamedResponseDiscriminatorType.StreamingThinking => "streaming_thinking",
                AgentStreamedResponseDiscriminatorType.StreamingThinkingEnd => "streaming_thinking_end",
                AgentStreamedResponseDiscriminatorType.ToolInput => "tool_input",
                AgentStreamedResponseDiscriminatorType.ToolOutput => "tool_output",
                AgentStreamedResponseDiscriminatorType.StructuredOutput => "structured_output",
                AgentStreamedResponseDiscriminatorType.ContextLimitExceeded => "context_limit_exceeded",
                AgentStreamedResponseDiscriminatorType.StepTransitionLimitExceeded => "step_transition_limit_exceeded",
                AgentStreamedResponseDiscriminatorType.SessionInterrupted => "session_interrupted",
                AgentStreamedResponseDiscriminatorType.ImageRead => "image_read",
                AgentStreamedResponseDiscriminatorType.StepTransition => "step_transition",
                AgentStreamedResponseDiscriminatorType.ContextConsumed => "context_consumed",
                AgentStreamedResponseDiscriminatorType.CompactionStarted => "compaction_started",
                AgentStreamedResponseDiscriminatorType.Compaction => "compaction",
                AgentStreamedResponseDiscriminatorType.Error => "error",
                AgentStreamedResponseDiscriminatorType.End => "end",
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
                "input_message" => AgentStreamedResponseDiscriminatorType.InputMessage,
                "streaming_agent_output" => AgentStreamedResponseDiscriminatorType.StreamingAgentOutput,
                "streaming_agent_output_end" => AgentStreamedResponseDiscriminatorType.StreamingAgentOutputEnd,
                "streaming_thinking" => AgentStreamedResponseDiscriminatorType.StreamingThinking,
                "streaming_thinking_end" => AgentStreamedResponseDiscriminatorType.StreamingThinkingEnd,
                "tool_input" => AgentStreamedResponseDiscriminatorType.ToolInput,
                "tool_output" => AgentStreamedResponseDiscriminatorType.ToolOutput,
                "structured_output" => AgentStreamedResponseDiscriminatorType.StructuredOutput,
                "context_limit_exceeded" => AgentStreamedResponseDiscriminatorType.ContextLimitExceeded,
                "step_transition_limit_exceeded" => AgentStreamedResponseDiscriminatorType.StepTransitionLimitExceeded,
                "session_interrupted" => AgentStreamedResponseDiscriminatorType.SessionInterrupted,
                "image_read" => AgentStreamedResponseDiscriminatorType.ImageRead,
                "step_transition" => AgentStreamedResponseDiscriminatorType.StepTransition,
                "context_consumed" => AgentStreamedResponseDiscriminatorType.ContextConsumed,
                "compaction_started" => AgentStreamedResponseDiscriminatorType.CompactionStarted,
                "compaction" => AgentStreamedResponseDiscriminatorType.Compaction,
                "error" => AgentStreamedResponseDiscriminatorType.Error,
                "end" => AgentStreamedResponseDiscriminatorType.End,
                _ => null,
            };
        }
    }
}
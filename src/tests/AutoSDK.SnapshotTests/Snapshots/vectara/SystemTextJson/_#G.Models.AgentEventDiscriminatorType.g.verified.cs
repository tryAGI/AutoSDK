//HintName: G.Models.AgentEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InputMessage,
        /// <summary>
        /// 
        /// </summary>
        SkillLoad,
        /// <summary>
        /// 
        /// </summary>
        ArtifactUpload,
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
        Thinking,
        /// <summary>
        /// 
        /// </summary>
        AgentOutput,
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
        Compaction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentEventDiscriminatorType value)
        {
            return value switch
            {
                AgentEventDiscriminatorType.InputMessage => "input_message",
                AgentEventDiscriminatorType.SkillLoad => "skill_load",
                AgentEventDiscriminatorType.ArtifactUpload => "artifact_upload",
                AgentEventDiscriminatorType.ToolInput => "tool_input",
                AgentEventDiscriminatorType.ToolOutput => "tool_output",
                AgentEventDiscriminatorType.Thinking => "thinking",
                AgentEventDiscriminatorType.AgentOutput => "agent_output",
                AgentEventDiscriminatorType.StructuredOutput => "structured_output",
                AgentEventDiscriminatorType.ContextLimitExceeded => "context_limit_exceeded",
                AgentEventDiscriminatorType.StepTransitionLimitExceeded => "step_transition_limit_exceeded",
                AgentEventDiscriminatorType.SessionInterrupted => "session_interrupted",
                AgentEventDiscriminatorType.ImageRead => "image_read",
                AgentEventDiscriminatorType.StepTransition => "step_transition",
                AgentEventDiscriminatorType.Compaction => "compaction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_message" => AgentEventDiscriminatorType.InputMessage,
                "skill_load" => AgentEventDiscriminatorType.SkillLoad,
                "artifact_upload" => AgentEventDiscriminatorType.ArtifactUpload,
                "tool_input" => AgentEventDiscriminatorType.ToolInput,
                "tool_output" => AgentEventDiscriminatorType.ToolOutput,
                "thinking" => AgentEventDiscriminatorType.Thinking,
                "agent_output" => AgentEventDiscriminatorType.AgentOutput,
                "structured_output" => AgentEventDiscriminatorType.StructuredOutput,
                "context_limit_exceeded" => AgentEventDiscriminatorType.ContextLimitExceeded,
                "step_transition_limit_exceeded" => AgentEventDiscriminatorType.StepTransitionLimitExceeded,
                "session_interrupted" => AgentEventDiscriminatorType.SessionInterrupted,
                "image_read" => AgentEventDiscriminatorType.ImageRead,
                "step_transition" => AgentEventDiscriminatorType.StepTransition,
                "compaction" => AgentEventDiscriminatorType.Compaction,
                _ => null,
            };
        }
    }
}
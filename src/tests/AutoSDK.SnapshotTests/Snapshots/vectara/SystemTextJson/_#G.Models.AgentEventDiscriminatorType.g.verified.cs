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
        AgentOutput,
        /// <summary>
        /// 
        /// </summary>
        ArtifactUpload,
        /// <summary>
        /// 
        /// </summary>
        Compaction,
        /// <summary>
        /// 
        /// </summary>
        ContextLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        ImageRead,
        /// <summary>
        /// 
        /// </summary>
        InputMessage,
        /// <summary>
        /// 
        /// </summary>
        SessionInterrupted,
        /// <summary>
        /// 
        /// </summary>
        SkillLoad,
        /// <summary>
        /// 
        /// </summary>
        StepTransition,
        /// <summary>
        /// 
        /// </summary>
        StepTransitionLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        StructuredOutput,
        /// <summary>
        /// 
        /// </summary>
        Thinking,
        /// <summary>
        /// 
        /// </summary>
        ToolInput,
        /// <summary>
        /// 
        /// </summary>
        ToolOutput,
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
                AgentEventDiscriminatorType.AgentOutput => "agent_output",
                AgentEventDiscriminatorType.ArtifactUpload => "artifact_upload",
                AgentEventDiscriminatorType.Compaction => "compaction",
                AgentEventDiscriminatorType.ContextLimitExceeded => "context_limit_exceeded",
                AgentEventDiscriminatorType.ImageRead => "image_read",
                AgentEventDiscriminatorType.InputMessage => "input_message",
                AgentEventDiscriminatorType.SessionInterrupted => "session_interrupted",
                AgentEventDiscriminatorType.SkillLoad => "skill_load",
                AgentEventDiscriminatorType.StepTransition => "step_transition",
                AgentEventDiscriminatorType.StepTransitionLimitExceeded => "step_transition_limit_exceeded",
                AgentEventDiscriminatorType.StructuredOutput => "structured_output",
                AgentEventDiscriminatorType.Thinking => "thinking",
                AgentEventDiscriminatorType.ToolInput => "tool_input",
                AgentEventDiscriminatorType.ToolOutput => "tool_output",
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
                "agent_output" => AgentEventDiscriminatorType.AgentOutput,
                "artifact_upload" => AgentEventDiscriminatorType.ArtifactUpload,
                "compaction" => AgentEventDiscriminatorType.Compaction,
                "context_limit_exceeded" => AgentEventDiscriminatorType.ContextLimitExceeded,
                "image_read" => AgentEventDiscriminatorType.ImageRead,
                "input_message" => AgentEventDiscriminatorType.InputMessage,
                "session_interrupted" => AgentEventDiscriminatorType.SessionInterrupted,
                "skill_load" => AgentEventDiscriminatorType.SkillLoad,
                "step_transition" => AgentEventDiscriminatorType.StepTransition,
                "step_transition_limit_exceeded" => AgentEventDiscriminatorType.StepTransitionLimitExceeded,
                "structured_output" => AgentEventDiscriminatorType.StructuredOutput,
                "thinking" => AgentEventDiscriminatorType.Thinking,
                "tool_input" => AgentEventDiscriminatorType.ToolInput,
                "tool_output" => AgentEventDiscriminatorType.ToolOutput,
                _ => null,
            };
        }
    }
}
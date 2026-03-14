//HintName: G.Models.AgentEventDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="input_message")]
        InputMessage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skill_load")]
        SkillLoad,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="artifact_upload")]
        ArtifactUpload,
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thinking")]
        Thinking,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent_output")]
        AgentOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="structured_output")]
        StructuredOutput,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="context_limit_exceeded")]
        ContextLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="step_transition_limit_exceeded")]
        StepTransitionLimitExceeded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session_interrupted")]
        SessionInterrupted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_read")]
        ImageRead,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="step_transition")]
        StepTransition,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="compaction")]
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
//HintName: G.Models.AgentUpdateDtoLlmVariant2Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentUpdateDtoLlmVariant2Template
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rag-grounded")]
        RagGrounded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rag-ungrounded")]
        RagUngrounded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentUpdateDtoLlmVariant2TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentUpdateDtoLlmVariant2Template value)
        {
            return value switch
            {
                AgentUpdateDtoLlmVariant2Template.Assistant => "assistant",
                AgentUpdateDtoLlmVariant2Template.RagGrounded => "rag-grounded",
                AgentUpdateDtoLlmVariant2Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentUpdateDtoLlmVariant2Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentUpdateDtoLlmVariant2Template.Assistant,
                "rag-grounded" => AgentUpdateDtoLlmVariant2Template.RagGrounded,
                "rag-ungrounded" => AgentUpdateDtoLlmVariant2Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
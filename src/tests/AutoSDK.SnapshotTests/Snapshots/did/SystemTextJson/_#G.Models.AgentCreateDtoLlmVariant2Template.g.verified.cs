//HintName: G.Models.AgentCreateDtoLlmVariant2Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum AgentCreateDtoLlmVariant2Template
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        RagGrounded,
        /// <summary>
        /// 
        /// </summary>
        RagUngrounded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentCreateDtoLlmVariant2TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoLlmVariant2Template value)
        {
            return value switch
            {
                AgentCreateDtoLlmVariant2Template.Assistant => "assistant",
                AgentCreateDtoLlmVariant2Template.RagGrounded => "rag-grounded",
                AgentCreateDtoLlmVariant2Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoLlmVariant2Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentCreateDtoLlmVariant2Template.Assistant,
                "rag-grounded" => AgentCreateDtoLlmVariant2Template.RagGrounded,
                "rag-ungrounded" => AgentCreateDtoLlmVariant2Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
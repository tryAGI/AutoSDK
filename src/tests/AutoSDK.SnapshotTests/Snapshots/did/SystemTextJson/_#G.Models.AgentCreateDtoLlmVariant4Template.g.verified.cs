//HintName: G.Models.AgentCreateDtoLlmVariant4Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum AgentCreateDtoLlmVariant4Template
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
    public static class AgentCreateDtoLlmVariant4TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoLlmVariant4Template value)
        {
            return value switch
            {
                AgentCreateDtoLlmVariant4Template.Assistant => "assistant",
                AgentCreateDtoLlmVariant4Template.RagGrounded => "rag-grounded",
                AgentCreateDtoLlmVariant4Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoLlmVariant4Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentCreateDtoLlmVariant4Template.Assistant,
                "rag-grounded" => AgentCreateDtoLlmVariant4Template.RagGrounded,
                "rag-ungrounded" => AgentCreateDtoLlmVariant4Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
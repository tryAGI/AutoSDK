//HintName: G.Models.AgentCreateDtoLlmVariant5Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum AgentCreateDtoLlmVariant5Template
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
    public static class AgentCreateDtoLlmVariant5TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentCreateDtoLlmVariant5Template value)
        {
            return value switch
            {
                AgentCreateDtoLlmVariant5Template.Assistant => "assistant",
                AgentCreateDtoLlmVariant5Template.RagGrounded => "rag-grounded",
                AgentCreateDtoLlmVariant5Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentCreateDtoLlmVariant5Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentCreateDtoLlmVariant5Template.Assistant,
                "rag-grounded" => AgentCreateDtoLlmVariant5Template.RagGrounded,
                "rag-ungrounded" => AgentCreateDtoLlmVariant5Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
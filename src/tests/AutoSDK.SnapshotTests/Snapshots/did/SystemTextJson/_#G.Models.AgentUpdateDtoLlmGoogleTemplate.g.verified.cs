//HintName: G.Models.AgentUpdateDtoLlmGoogleTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum AgentUpdateDtoLlmGoogleTemplate
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
    public static class AgentUpdateDtoLlmGoogleTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentUpdateDtoLlmGoogleTemplate value)
        {
            return value switch
            {
                AgentUpdateDtoLlmGoogleTemplate.Assistant => "assistant",
                AgentUpdateDtoLlmGoogleTemplate.RagGrounded => "rag-grounded",
                AgentUpdateDtoLlmGoogleTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentUpdateDtoLlmGoogleTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentUpdateDtoLlmGoogleTemplate.Assistant,
                "rag-grounded" => AgentUpdateDtoLlmGoogleTemplate.RagGrounded,
                "rag-ungrounded" => AgentUpdateDtoLlmGoogleTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
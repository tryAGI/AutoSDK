//HintName: G.Models.AgentResponseDtoVariant1LlmGoogleTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum AgentResponseDtoVariant1LlmGoogleTemplate
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
    public static class AgentResponseDtoVariant1LlmGoogleTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1LlmGoogleTemplate value)
        {
            return value switch
            {
                AgentResponseDtoVariant1LlmGoogleTemplate.Assistant => "assistant",
                AgentResponseDtoVariant1LlmGoogleTemplate.RagGrounded => "rag-grounded",
                AgentResponseDtoVariant1LlmGoogleTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1LlmGoogleTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentResponseDtoVariant1LlmGoogleTemplate.Assistant,
                "rag-grounded" => AgentResponseDtoVariant1LlmGoogleTemplate.RagGrounded,
                "rag-ungrounded" => AgentResponseDtoVariant1LlmGoogleTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
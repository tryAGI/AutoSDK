//HintName: G.Models.AgentResponseDtoVariant1LlmDIdTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum AgentResponseDtoVariant1LlmDIdTemplate
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
    public static class AgentResponseDtoVariant1LlmDIdTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1LlmDIdTemplate value)
        {
            return value switch
            {
                AgentResponseDtoVariant1LlmDIdTemplate.Assistant => "assistant",
                AgentResponseDtoVariant1LlmDIdTemplate.RagGrounded => "rag-grounded",
                AgentResponseDtoVariant1LlmDIdTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1LlmDIdTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentResponseDtoVariant1LlmDIdTemplate.Assistant,
                "rag-grounded" => AgentResponseDtoVariant1LlmDIdTemplate.RagGrounded,
                "rag-ungrounded" => AgentResponseDtoVariant1LlmDIdTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
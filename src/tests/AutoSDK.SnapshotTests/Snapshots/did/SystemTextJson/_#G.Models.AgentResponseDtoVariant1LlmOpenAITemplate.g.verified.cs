//HintName: G.Models.AgentResponseDtoVariant1LlmOpenAITemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum AgentResponseDtoVariant1LlmOpenAITemplate
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
    public static class AgentResponseDtoVariant1LlmOpenAITemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1LlmOpenAITemplate value)
        {
            return value switch
            {
                AgentResponseDtoVariant1LlmOpenAITemplate.Assistant => "assistant",
                AgentResponseDtoVariant1LlmOpenAITemplate.RagGrounded => "rag-grounded",
                AgentResponseDtoVariant1LlmOpenAITemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1LlmOpenAITemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentResponseDtoVariant1LlmOpenAITemplate.Assistant,
                "rag-grounded" => AgentResponseDtoVariant1LlmOpenAITemplate.RagGrounded,
                "rag-ungrounded" => AgentResponseDtoVariant1LlmOpenAITemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
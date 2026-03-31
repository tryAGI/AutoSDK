//HintName: G.Models.AgentUpdateDtoLlmOpenAITemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum AgentUpdateDtoLlmOpenAITemplate
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
    public static class AgentUpdateDtoLlmOpenAITemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentUpdateDtoLlmOpenAITemplate value)
        {
            return value switch
            {
                AgentUpdateDtoLlmOpenAITemplate.Assistant => "assistant",
                AgentUpdateDtoLlmOpenAITemplate.RagGrounded => "rag-grounded",
                AgentUpdateDtoLlmOpenAITemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentUpdateDtoLlmOpenAITemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentUpdateDtoLlmOpenAITemplate.Assistant,
                "rag-grounded" => AgentUpdateDtoLlmOpenAITemplate.RagGrounded,
                "rag-ungrounded" => AgentUpdateDtoLlmOpenAITemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
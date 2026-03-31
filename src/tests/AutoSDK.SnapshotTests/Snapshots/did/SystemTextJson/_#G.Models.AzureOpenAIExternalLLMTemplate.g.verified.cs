//HintName: G.Models.AzureOpenAIExternalLLMTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum AzureOpenAIExternalLLMTemplate
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
    public static class AzureOpenAIExternalLLMTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureOpenAIExternalLLMTemplate value)
        {
            return value switch
            {
                AzureOpenAIExternalLLMTemplate.Assistant => "assistant",
                AzureOpenAIExternalLLMTemplate.RagGrounded => "rag-grounded",
                AzureOpenAIExternalLLMTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureOpenAIExternalLLMTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AzureOpenAIExternalLLMTemplate.Assistant,
                "rag-grounded" => AzureOpenAIExternalLLMTemplate.RagGrounded,
                "rag-ungrounded" => AzureOpenAIExternalLLMTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
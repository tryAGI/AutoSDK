//HintName: G.Models.AzureOpenAIExternalLLMCreateDtoTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum AzureOpenAIExternalLLMCreateDtoTemplate
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
    public static class AzureOpenAIExternalLLMCreateDtoTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureOpenAIExternalLLMCreateDtoTemplate value)
        {
            return value switch
            {
                AzureOpenAIExternalLLMCreateDtoTemplate.Assistant => "assistant",
                AzureOpenAIExternalLLMCreateDtoTemplate.RagGrounded => "rag-grounded",
                AzureOpenAIExternalLLMCreateDtoTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureOpenAIExternalLLMCreateDtoTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AzureOpenAIExternalLLMCreateDtoTemplate.Assistant,
                "rag-grounded" => AzureOpenAIExternalLLMCreateDtoTemplate.RagGrounded,
                "rag-ungrounded" => AzureOpenAIExternalLLMCreateDtoTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
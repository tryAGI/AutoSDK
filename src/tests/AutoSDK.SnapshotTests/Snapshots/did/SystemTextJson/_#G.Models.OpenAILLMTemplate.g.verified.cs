//HintName: G.Models.OpenAILLMTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum OpenAILLMTemplate
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
    public static class OpenAILLMTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAILLMTemplate value)
        {
            return value switch
            {
                OpenAILLMTemplate.Assistant => "assistant",
                OpenAILLMTemplate.RagGrounded => "rag-grounded",
                OpenAILLMTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAILLMTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => OpenAILLMTemplate.Assistant,
                "rag-grounded" => OpenAILLMTemplate.RagGrounded,
                "rag-ungrounded" => OpenAILLMTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
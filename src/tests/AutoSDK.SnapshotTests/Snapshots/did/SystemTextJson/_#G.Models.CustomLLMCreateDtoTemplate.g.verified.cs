//HintName: G.Models.CustomLLMCreateDtoTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum CustomLLMCreateDtoTemplate
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
    public static class CustomLLMCreateDtoTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomLLMCreateDtoTemplate value)
        {
            return value switch
            {
                CustomLLMCreateDtoTemplate.Assistant => "assistant",
                CustomLLMCreateDtoTemplate.RagGrounded => "rag-grounded",
                CustomLLMCreateDtoTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomLLMCreateDtoTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => CustomLLMCreateDtoTemplate.Assistant,
                "rag-grounded" => CustomLLMCreateDtoTemplate.RagGrounded,
                "rag-ungrounded" => CustomLLMCreateDtoTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
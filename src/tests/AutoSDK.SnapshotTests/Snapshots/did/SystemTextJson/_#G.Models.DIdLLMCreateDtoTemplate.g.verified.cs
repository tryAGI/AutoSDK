//HintName: G.Models.DIdLLMCreateDtoTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum DIdLLMCreateDtoTemplate
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
    public static class DIdLLMCreateDtoTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DIdLLMCreateDtoTemplate value)
        {
            return value switch
            {
                DIdLLMCreateDtoTemplate.Assistant => "assistant",
                DIdLLMCreateDtoTemplate.RagGrounded => "rag-grounded",
                DIdLLMCreateDtoTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DIdLLMCreateDtoTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => DIdLLMCreateDtoTemplate.Assistant,
                "rag-grounded" => DIdLLMCreateDtoTemplate.RagGrounded,
                "rag-ungrounded" => DIdLLMCreateDtoTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
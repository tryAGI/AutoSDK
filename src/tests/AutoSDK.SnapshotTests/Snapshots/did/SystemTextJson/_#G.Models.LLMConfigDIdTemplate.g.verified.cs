//HintName: G.Models.LLMConfigDIdTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum LLMConfigDIdTemplate
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
    public static class LLMConfigDIdTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigDIdTemplate value)
        {
            return value switch
            {
                LLMConfigDIdTemplate.Assistant => "assistant",
                LLMConfigDIdTemplate.RagGrounded => "rag-grounded",
                LLMConfigDIdTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigDIdTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => LLMConfigDIdTemplate.Assistant,
                "rag-grounded" => LLMConfigDIdTemplate.RagGrounded,
                "rag-ungrounded" => LLMConfigDIdTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
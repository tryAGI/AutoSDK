//HintName: G.Models.DIdLLMTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum DIdLLMTemplate
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
    public static class DIdLLMTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DIdLLMTemplate value)
        {
            return value switch
            {
                DIdLLMTemplate.Assistant => "assistant",
                DIdLLMTemplate.RagGrounded => "rag-grounded",
                DIdLLMTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DIdLLMTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => DIdLLMTemplate.Assistant,
                "rag-grounded" => DIdLLMTemplate.RagGrounded,
                "rag-ungrounded" => DIdLLMTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.GoogleLLMTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum GoogleLLMTemplate
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
    public static class GoogleLLMTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleLLMTemplate value)
        {
            return value switch
            {
                GoogleLLMTemplate.Assistant => "assistant",
                GoogleLLMTemplate.RagGrounded => "rag-grounded",
                GoogleLLMTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleLLMTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => GoogleLLMTemplate.Assistant,
                "rag-grounded" => GoogleLLMTemplate.RagGrounded,
                "rag-ungrounded" => GoogleLLMTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
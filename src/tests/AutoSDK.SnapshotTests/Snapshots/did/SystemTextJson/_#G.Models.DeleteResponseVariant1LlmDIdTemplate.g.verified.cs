//HintName: G.Models.DeleteResponseVariant1LlmDIdTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum DeleteResponseVariant1LlmDIdTemplate
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
    public static class DeleteResponseVariant1LlmDIdTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteResponseVariant1LlmDIdTemplate value)
        {
            return value switch
            {
                DeleteResponseVariant1LlmDIdTemplate.Assistant => "assistant",
                DeleteResponseVariant1LlmDIdTemplate.RagGrounded => "rag-grounded",
                DeleteResponseVariant1LlmDIdTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteResponseVariant1LlmDIdTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => DeleteResponseVariant1LlmDIdTemplate.Assistant,
                "rag-grounded" => DeleteResponseVariant1LlmDIdTemplate.RagGrounded,
                "rag-ungrounded" => DeleteResponseVariant1LlmDIdTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
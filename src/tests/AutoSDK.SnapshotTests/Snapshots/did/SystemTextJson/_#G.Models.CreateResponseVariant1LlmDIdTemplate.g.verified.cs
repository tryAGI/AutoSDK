//HintName: G.Models.CreateResponseVariant1LlmDIdTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum CreateResponseVariant1LlmDIdTemplate
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
    public static class CreateResponseVariant1LlmDIdTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseVariant1LlmDIdTemplate value)
        {
            return value switch
            {
                CreateResponseVariant1LlmDIdTemplate.Assistant => "assistant",
                CreateResponseVariant1LlmDIdTemplate.RagGrounded => "rag-grounded",
                CreateResponseVariant1LlmDIdTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseVariant1LlmDIdTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => CreateResponseVariant1LlmDIdTemplate.Assistant,
                "rag-grounded" => CreateResponseVariant1LlmDIdTemplate.RagGrounded,
                "rag-ungrounded" => CreateResponseVariant1LlmDIdTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
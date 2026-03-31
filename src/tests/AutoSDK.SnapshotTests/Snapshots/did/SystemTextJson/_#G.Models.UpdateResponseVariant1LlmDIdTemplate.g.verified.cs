//HintName: G.Models.UpdateResponseVariant1LlmDIdTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum UpdateResponseVariant1LlmDIdTemplate
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
    public static class UpdateResponseVariant1LlmDIdTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1LlmDIdTemplate value)
        {
            return value switch
            {
                UpdateResponseVariant1LlmDIdTemplate.Assistant => "assistant",
                UpdateResponseVariant1LlmDIdTemplate.RagGrounded => "rag-grounded",
                UpdateResponseVariant1LlmDIdTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1LlmDIdTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => UpdateResponseVariant1LlmDIdTemplate.Assistant,
                "rag-grounded" => UpdateResponseVariant1LlmDIdTemplate.RagGrounded,
                "rag-ungrounded" => UpdateResponseVariant1LlmDIdTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
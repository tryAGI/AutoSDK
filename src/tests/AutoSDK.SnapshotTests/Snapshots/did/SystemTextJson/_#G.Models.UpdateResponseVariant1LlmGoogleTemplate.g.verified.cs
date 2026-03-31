//HintName: G.Models.UpdateResponseVariant1LlmGoogleTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum UpdateResponseVariant1LlmGoogleTemplate
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
    public static class UpdateResponseVariant1LlmGoogleTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1LlmGoogleTemplate value)
        {
            return value switch
            {
                UpdateResponseVariant1LlmGoogleTemplate.Assistant => "assistant",
                UpdateResponseVariant1LlmGoogleTemplate.RagGrounded => "rag-grounded",
                UpdateResponseVariant1LlmGoogleTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1LlmGoogleTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => UpdateResponseVariant1LlmGoogleTemplate.Assistant,
                "rag-grounded" => UpdateResponseVariant1LlmGoogleTemplate.RagGrounded,
                "rag-ungrounded" => UpdateResponseVariant1LlmGoogleTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
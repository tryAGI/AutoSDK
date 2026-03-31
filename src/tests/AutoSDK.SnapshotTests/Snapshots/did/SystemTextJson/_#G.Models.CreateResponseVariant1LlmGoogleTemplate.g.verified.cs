//HintName: G.Models.CreateResponseVariant1LlmGoogleTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum CreateResponseVariant1LlmGoogleTemplate
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
    public static class CreateResponseVariant1LlmGoogleTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseVariant1LlmGoogleTemplate value)
        {
            return value switch
            {
                CreateResponseVariant1LlmGoogleTemplate.Assistant => "assistant",
                CreateResponseVariant1LlmGoogleTemplate.RagGrounded => "rag-grounded",
                CreateResponseVariant1LlmGoogleTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseVariant1LlmGoogleTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => CreateResponseVariant1LlmGoogleTemplate.Assistant,
                "rag-grounded" => CreateResponseVariant1LlmGoogleTemplate.RagGrounded,
                "rag-ungrounded" => CreateResponseVariant1LlmGoogleTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
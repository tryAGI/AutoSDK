//HintName: G.Models.CreateResponseVariant1LlmVariant2Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum CreateResponseVariant1LlmVariant2Template
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
    public static class CreateResponseVariant1LlmVariant2TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseVariant1LlmVariant2Template value)
        {
            return value switch
            {
                CreateResponseVariant1LlmVariant2Template.Assistant => "assistant",
                CreateResponseVariant1LlmVariant2Template.RagGrounded => "rag-grounded",
                CreateResponseVariant1LlmVariant2Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseVariant1LlmVariant2Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => CreateResponseVariant1LlmVariant2Template.Assistant,
                "rag-grounded" => CreateResponseVariant1LlmVariant2Template.RagGrounded,
                "rag-ungrounded" => CreateResponseVariant1LlmVariant2Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
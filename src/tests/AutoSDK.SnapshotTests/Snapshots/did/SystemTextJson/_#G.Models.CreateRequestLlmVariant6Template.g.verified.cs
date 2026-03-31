//HintName: G.Models.CreateRequestLlmVariant6Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum CreateRequestLlmVariant6Template
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
    public static class CreateRequestLlmVariant6TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestLlmVariant6Template value)
        {
            return value switch
            {
                CreateRequestLlmVariant6Template.Assistant => "assistant",
                CreateRequestLlmVariant6Template.RagGrounded => "rag-grounded",
                CreateRequestLlmVariant6Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestLlmVariant6Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => CreateRequestLlmVariant6Template.Assistant,
                "rag-grounded" => CreateRequestLlmVariant6Template.RagGrounded,
                "rag-ungrounded" => CreateRequestLlmVariant6Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.DeleteResponseVariant1LlmVariant2Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum DeleteResponseVariant1LlmVariant2Template
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
    public static class DeleteResponseVariant1LlmVariant2TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteResponseVariant1LlmVariant2Template value)
        {
            return value switch
            {
                DeleteResponseVariant1LlmVariant2Template.Assistant => "assistant",
                DeleteResponseVariant1LlmVariant2Template.RagGrounded => "rag-grounded",
                DeleteResponseVariant1LlmVariant2Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteResponseVariant1LlmVariant2Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => DeleteResponseVariant1LlmVariant2Template.Assistant,
                "rag-grounded" => DeleteResponseVariant1LlmVariant2Template.RagGrounded,
                "rag-ungrounded" => DeleteResponseVariant1LlmVariant2Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
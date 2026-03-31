//HintName: G.Models.UpdateRequestLlmVariant3Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum UpdateRequestLlmVariant3Template
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
    public static class UpdateRequestLlmVariant3TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRequestLlmVariant3Template value)
        {
            return value switch
            {
                UpdateRequestLlmVariant3Template.Assistant => "assistant",
                UpdateRequestLlmVariant3Template.RagGrounded => "rag-grounded",
                UpdateRequestLlmVariant3Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRequestLlmVariant3Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => UpdateRequestLlmVariant3Template.Assistant,
                "rag-grounded" => UpdateRequestLlmVariant3Template.RagGrounded,
                "rag-ungrounded" => UpdateRequestLlmVariant3Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
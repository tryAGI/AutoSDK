//HintName: G.Models.UpdateRequestLlmDIdTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum UpdateRequestLlmDIdTemplate
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
    public static class UpdateRequestLlmDIdTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRequestLlmDIdTemplate value)
        {
            return value switch
            {
                UpdateRequestLlmDIdTemplate.Assistant => "assistant",
                UpdateRequestLlmDIdTemplate.RagGrounded => "rag-grounded",
                UpdateRequestLlmDIdTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRequestLlmDIdTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => UpdateRequestLlmDIdTemplate.Assistant,
                "rag-grounded" => UpdateRequestLlmDIdTemplate.RagGrounded,
                "rag-ungrounded" => UpdateRequestLlmDIdTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.UpdateRequestLlmOpenAITemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum UpdateRequestLlmOpenAITemplate
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
    public static class UpdateRequestLlmOpenAITemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateRequestLlmOpenAITemplate value)
        {
            return value switch
            {
                UpdateRequestLlmOpenAITemplate.Assistant => "assistant",
                UpdateRequestLlmOpenAITemplate.RagGrounded => "rag-grounded",
                UpdateRequestLlmOpenAITemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateRequestLlmOpenAITemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => UpdateRequestLlmOpenAITemplate.Assistant,
                "rag-grounded" => UpdateRequestLlmOpenAITemplate.RagGrounded,
                "rag-ungrounded" => UpdateRequestLlmOpenAITemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
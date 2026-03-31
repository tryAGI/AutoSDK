//HintName: G.Models.LLMConfigVariant2Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum LLMConfigVariant2Template
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
    public static class LLMConfigVariant2TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigVariant2Template value)
        {
            return value switch
            {
                LLMConfigVariant2Template.Assistant => "assistant",
                LLMConfigVariant2Template.RagGrounded => "rag-grounded",
                LLMConfigVariant2Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigVariant2Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => LLMConfigVariant2Template.Assistant,
                "rag-grounded" => LLMConfigVariant2Template.RagGrounded,
                "rag-ungrounded" => LLMConfigVariant2Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
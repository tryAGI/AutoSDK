//HintName: G.Models.LLMConfigCreateDtoVariant6Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum LLMConfigCreateDtoVariant6Template
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
    public static class LLMConfigCreateDtoVariant6TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCreateDtoVariant6Template value)
        {
            return value switch
            {
                LLMConfigCreateDtoVariant6Template.Assistant => "assistant",
                LLMConfigCreateDtoVariant6Template.RagGrounded => "rag-grounded",
                LLMConfigCreateDtoVariant6Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCreateDtoVariant6Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => LLMConfigCreateDtoVariant6Template.Assistant,
                "rag-grounded" => LLMConfigCreateDtoVariant6Template.RagGrounded,
                "rag-ungrounded" => LLMConfigCreateDtoVariant6Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
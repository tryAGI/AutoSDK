//HintName: G.Models.LLMConfigCreateDtoVariant3Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum LLMConfigCreateDtoVariant3Template
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
    public static class LLMConfigCreateDtoVariant3TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCreateDtoVariant3Template value)
        {
            return value switch
            {
                LLMConfigCreateDtoVariant3Template.Assistant => "assistant",
                LLMConfigCreateDtoVariant3Template.RagGrounded => "rag-grounded",
                LLMConfigCreateDtoVariant3Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCreateDtoVariant3Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => LLMConfigCreateDtoVariant3Template.Assistant,
                "rag-grounded" => LLMConfigCreateDtoVariant3Template.RagGrounded,
                "rag-ungrounded" => LLMConfigCreateDtoVariant3Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.LLMConfigCreateDtoVariant4Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum LLMConfigCreateDtoVariant4Template
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
    public static class LLMConfigCreateDtoVariant4TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCreateDtoVariant4Template value)
        {
            return value switch
            {
                LLMConfigCreateDtoVariant4Template.Assistant => "assistant",
                LLMConfigCreateDtoVariant4Template.RagGrounded => "rag-grounded",
                LLMConfigCreateDtoVariant4Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCreateDtoVariant4Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => LLMConfigCreateDtoVariant4Template.Assistant,
                "rag-grounded" => LLMConfigCreateDtoVariant4Template.RagGrounded,
                "rag-ungrounded" => LLMConfigCreateDtoVariant4Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
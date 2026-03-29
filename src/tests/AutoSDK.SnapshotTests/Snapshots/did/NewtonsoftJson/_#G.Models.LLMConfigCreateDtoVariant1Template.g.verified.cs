//HintName: G.Models.LLMConfigCreateDtoVariant1Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LLMConfigCreateDtoVariant1Template
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rag-grounded")]
        RagGrounded,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rag-ungrounded")]
        RagUngrounded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LLMConfigCreateDtoVariant1TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCreateDtoVariant1Template value)
        {
            return value switch
            {
                LLMConfigCreateDtoVariant1Template.Assistant => "assistant",
                LLMConfigCreateDtoVariant1Template.RagGrounded => "rag-grounded",
                LLMConfigCreateDtoVariant1Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCreateDtoVariant1Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => LLMConfigCreateDtoVariant1Template.Assistant,
                "rag-grounded" => LLMConfigCreateDtoVariant1Template.RagGrounded,
                "rag-ungrounded" => LLMConfigCreateDtoVariant1Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
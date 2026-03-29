//HintName: G.Models.LLMConfigCreateDtoVariant5Template.g.cs

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
    public enum LLMConfigCreateDtoVariant5Template
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
    public static class LLMConfigCreateDtoVariant5TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigCreateDtoVariant5Template value)
        {
            return value switch
            {
                LLMConfigCreateDtoVariant5Template.Assistant => "assistant",
                LLMConfigCreateDtoVariant5Template.RagGrounded => "rag-grounded",
                LLMConfigCreateDtoVariant5Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigCreateDtoVariant5Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => LLMConfigCreateDtoVariant5Template.Assistant,
                "rag-grounded" => LLMConfigCreateDtoVariant5Template.RagGrounded,
                "rag-ungrounded" => LLMConfigCreateDtoVariant5Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.OpenAIExternalLLMCreateDtoTemplate.g.cs

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
    public enum OpenAIExternalLLMCreateDtoTemplate
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
    public static class OpenAIExternalLLMCreateDtoTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIExternalLLMCreateDtoTemplate value)
        {
            return value switch
            {
                OpenAIExternalLLMCreateDtoTemplate.Assistant => "assistant",
                OpenAIExternalLLMCreateDtoTemplate.RagGrounded => "rag-grounded",
                OpenAIExternalLLMCreateDtoTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIExternalLLMCreateDtoTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => OpenAIExternalLLMCreateDtoTemplate.Assistant,
                "rag-grounded" => OpenAIExternalLLMCreateDtoTemplate.RagGrounded,
                "rag-ungrounded" => OpenAIExternalLLMCreateDtoTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
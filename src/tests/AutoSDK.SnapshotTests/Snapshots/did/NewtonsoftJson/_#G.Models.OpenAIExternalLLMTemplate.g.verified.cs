//HintName: G.Models.OpenAIExternalLLMTemplate.g.cs

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
    public enum OpenAIExternalLLMTemplate
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
    public static class OpenAIExternalLLMTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIExternalLLMTemplate value)
        {
            return value switch
            {
                OpenAIExternalLLMTemplate.Assistant => "assistant",
                OpenAIExternalLLMTemplate.RagGrounded => "rag-grounded",
                OpenAIExternalLLMTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIExternalLLMTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => OpenAIExternalLLMTemplate.Assistant,
                "rag-grounded" => OpenAIExternalLLMTemplate.RagGrounded,
                "rag-ungrounded" => OpenAIExternalLLMTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
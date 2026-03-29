//HintName: G.Models.CreateResponseVariant1LlmOpenAITemplate.g.cs

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
    public enum CreateResponseVariant1LlmOpenAITemplate
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
    public static class CreateResponseVariant1LlmOpenAITemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResponseVariant1LlmOpenAITemplate value)
        {
            return value switch
            {
                CreateResponseVariant1LlmOpenAITemplate.Assistant => "assistant",
                CreateResponseVariant1LlmOpenAITemplate.RagGrounded => "rag-grounded",
                CreateResponseVariant1LlmOpenAITemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResponseVariant1LlmOpenAITemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => CreateResponseVariant1LlmOpenAITemplate.Assistant,
                "rag-grounded" => CreateResponseVariant1LlmOpenAITemplate.RagGrounded,
                "rag-ungrounded" => CreateResponseVariant1LlmOpenAITemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
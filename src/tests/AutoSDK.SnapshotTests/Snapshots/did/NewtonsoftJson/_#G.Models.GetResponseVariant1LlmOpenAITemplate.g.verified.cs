//HintName: G.Models.GetResponseVariant1LlmOpenAITemplate.g.cs

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
    public enum GetResponseVariant1LlmOpenAITemplate
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
    public static class GetResponseVariant1LlmOpenAITemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseVariant1LlmOpenAITemplate value)
        {
            return value switch
            {
                GetResponseVariant1LlmOpenAITemplate.Assistant => "assistant",
                GetResponseVariant1LlmOpenAITemplate.RagGrounded => "rag-grounded",
                GetResponseVariant1LlmOpenAITemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseVariant1LlmOpenAITemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => GetResponseVariant1LlmOpenAITemplate.Assistant,
                "rag-grounded" => GetResponseVariant1LlmOpenAITemplate.RagGrounded,
                "rag-ungrounded" => GetResponseVariant1LlmOpenAITemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
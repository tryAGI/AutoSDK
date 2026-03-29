//HintName: G.Models.GetResponseVariant1LlmDIdTemplate.g.cs

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
    public enum GetResponseVariant1LlmDIdTemplate
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
    public static class GetResponseVariant1LlmDIdTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseVariant1LlmDIdTemplate value)
        {
            return value switch
            {
                GetResponseVariant1LlmDIdTemplate.Assistant => "assistant",
                GetResponseVariant1LlmDIdTemplate.RagGrounded => "rag-grounded",
                GetResponseVariant1LlmDIdTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseVariant1LlmDIdTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => GetResponseVariant1LlmDIdTemplate.Assistant,
                "rag-grounded" => GetResponseVariant1LlmDIdTemplate.RagGrounded,
                "rag-ungrounded" => GetResponseVariant1LlmDIdTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.GetResponseVariant1LlmVariant2Template.g.cs

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
    public enum GetResponseVariant1LlmVariant2Template
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
    public static class GetResponseVariant1LlmVariant2TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResponseVariant1LlmVariant2Template value)
        {
            return value switch
            {
                GetResponseVariant1LlmVariant2Template.Assistant => "assistant",
                GetResponseVariant1LlmVariant2Template.RagGrounded => "rag-grounded",
                GetResponseVariant1LlmVariant2Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResponseVariant1LlmVariant2Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => GetResponseVariant1LlmVariant2Template.Assistant,
                "rag-grounded" => GetResponseVariant1LlmVariant2Template.RagGrounded,
                "rag-ungrounded" => GetResponseVariant1LlmVariant2Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
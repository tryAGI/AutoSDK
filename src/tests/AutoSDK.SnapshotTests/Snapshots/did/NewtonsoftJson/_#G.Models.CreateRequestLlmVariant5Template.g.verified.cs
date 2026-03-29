//HintName: G.Models.CreateRequestLlmVariant5Template.g.cs

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
    public enum CreateRequestLlmVariant5Template
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
    public static class CreateRequestLlmVariant5TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestLlmVariant5Template value)
        {
            return value switch
            {
                CreateRequestLlmVariant5Template.Assistant => "assistant",
                CreateRequestLlmVariant5Template.RagGrounded => "rag-grounded",
                CreateRequestLlmVariant5Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestLlmVariant5Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => CreateRequestLlmVariant5Template.Assistant,
                "rag-grounded" => CreateRequestLlmVariant5Template.RagGrounded,
                "rag-ungrounded" => CreateRequestLlmVariant5Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
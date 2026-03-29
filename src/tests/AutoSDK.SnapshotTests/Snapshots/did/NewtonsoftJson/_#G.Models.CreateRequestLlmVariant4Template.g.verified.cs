//HintName: G.Models.CreateRequestLlmVariant4Template.g.cs

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
    public enum CreateRequestLlmVariant4Template
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
    public static class CreateRequestLlmVariant4TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateRequestLlmVariant4Template value)
        {
            return value switch
            {
                CreateRequestLlmVariant4Template.Assistant => "assistant",
                CreateRequestLlmVariant4Template.RagGrounded => "rag-grounded",
                CreateRequestLlmVariant4Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateRequestLlmVariant4Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => CreateRequestLlmVariant4Template.Assistant,
                "rag-grounded" => CreateRequestLlmVariant4Template.RagGrounded,
                "rag-ungrounded" => CreateRequestLlmVariant4Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
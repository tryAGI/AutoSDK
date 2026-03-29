//HintName: G.Models.ListMyAgentsResponseAgentVariant1LlmVariant3Template.g.cs

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
    public enum ListMyAgentsResponseAgentVariant1LlmVariant3Template
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
    public static class ListMyAgentsResponseAgentVariant1LlmVariant3TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1LlmVariant3Template value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1LlmVariant3Template.Assistant => "assistant",
                ListMyAgentsResponseAgentVariant1LlmVariant3Template.RagGrounded => "rag-grounded",
                ListMyAgentsResponseAgentVariant1LlmVariant3Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1LlmVariant3Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ListMyAgentsResponseAgentVariant1LlmVariant3Template.Assistant,
                "rag-grounded" => ListMyAgentsResponseAgentVariant1LlmVariant3Template.RagGrounded,
                "rag-ungrounded" => ListMyAgentsResponseAgentVariant1LlmVariant3Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ListMyAgentsResponseAgentVariant1LlmGoogleTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum ListMyAgentsResponseAgentVariant1LlmGoogleTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        RagGrounded,
        /// <summary>
        /// 
        /// </summary>
        RagUngrounded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListMyAgentsResponseAgentVariant1LlmGoogleTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1LlmGoogleTemplate value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1LlmGoogleTemplate.Assistant => "assistant",
                ListMyAgentsResponseAgentVariant1LlmGoogleTemplate.RagGrounded => "rag-grounded",
                ListMyAgentsResponseAgentVariant1LlmGoogleTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1LlmGoogleTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ListMyAgentsResponseAgentVariant1LlmGoogleTemplate.Assistant,
                "rag-grounded" => ListMyAgentsResponseAgentVariant1LlmGoogleTemplate.RagGrounded,
                "rag-ungrounded" => ListMyAgentsResponseAgentVariant1LlmGoogleTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
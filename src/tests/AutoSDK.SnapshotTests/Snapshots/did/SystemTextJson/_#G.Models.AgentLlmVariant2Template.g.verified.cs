//HintName: G.Models.AgentLlmVariant2Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum AgentLlmVariant2Template
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
    public static class AgentLlmVariant2TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentLlmVariant2Template value)
        {
            return value switch
            {
                AgentLlmVariant2Template.Assistant => "assistant",
                AgentLlmVariant2Template.RagGrounded => "rag-grounded",
                AgentLlmVariant2Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentLlmVariant2Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentLlmVariant2Template.Assistant,
                "rag-grounded" => AgentLlmVariant2Template.RagGrounded,
                "rag-ungrounded" => AgentLlmVariant2Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
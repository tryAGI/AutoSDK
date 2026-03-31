//HintName: G.Models.AgentLlmVariant3Template.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How the Agent uses knowledge when generating responses.<br/>
    /// - RAG-Grounded: Uses only provided knowledge<br/>
    /// - RAG-Ungrounded: Uses provided knowledge and general model knowledge<br/>
    /// - Assistant: Uses general model knowledge only
    /// </summary>
    public enum AgentLlmVariant3Template
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
    public static class AgentLlmVariant3TemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentLlmVariant3Template value)
        {
            return value switch
            {
                AgentLlmVariant3Template.Assistant => "assistant",
                AgentLlmVariant3Template.RagGrounded => "rag-grounded",
                AgentLlmVariant3Template.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentLlmVariant3Template? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentLlmVariant3Template.Assistant,
                "rag-grounded" => AgentLlmVariant3Template.RagGrounded,
                "rag-ungrounded" => AgentLlmVariant3Template.RagUngrounded,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.AgentTemplate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentTemplate
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
    public static class AgentTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentTemplate value)
        {
            return value switch
            {
                AgentTemplate.Assistant => "assistant",
                AgentTemplate.RagGrounded => "rag-grounded",
                AgentTemplate.RagUngrounded => "rag-ungrounded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentTemplate? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AgentTemplate.Assistant,
                "rag-grounded" => AgentTemplate.RagGrounded,
                "rag-ungrounded" => AgentTemplate.RagUngrounded,
                _ => null,
            };
        }
    }
}
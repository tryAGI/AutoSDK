//HintName: G.Models.UltravoxV1CallToolDefaultReaction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates the default for how the agent should proceed after the tool is invoked.<br/>
    ///  Can be overridden by the tool implementation via the X-Ultravox-Agent-Reaction<br/>
    ///  header.
    /// </summary>
    public enum UltravoxV1CallToolDefaultReaction
    {
        /// <summary>
        /// 
        /// </summary>
        AgentReactionListens,
        /// <summary>
        /// 
        /// </summary>
        AgentReactionSpeaks,
        /// <summary>
        /// 
        /// </summary>
        AgentReactionSpeaksOnce,
        /// <summary>
        /// 
        /// </summary>
        AgentReactionUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1CallToolDefaultReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1CallToolDefaultReaction value)
        {
            return value switch
            {
                UltravoxV1CallToolDefaultReaction.AgentReactionListens => "AGENT_REACTION_LISTENS",
                UltravoxV1CallToolDefaultReaction.AgentReactionSpeaks => "AGENT_REACTION_SPEAKS",
                UltravoxV1CallToolDefaultReaction.AgentReactionSpeaksOnce => "AGENT_REACTION_SPEAKS_ONCE",
                UltravoxV1CallToolDefaultReaction.AgentReactionUnspecified => "AGENT_REACTION_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1CallToolDefaultReaction? ToEnum(string value)
        {
            return value switch
            {
                "AGENT_REACTION_LISTENS" => UltravoxV1CallToolDefaultReaction.AgentReactionListens,
                "AGENT_REACTION_SPEAKS" => UltravoxV1CallToolDefaultReaction.AgentReactionSpeaks,
                "AGENT_REACTION_SPEAKS_ONCE" => UltravoxV1CallToolDefaultReaction.AgentReactionSpeaksOnce,
                "AGENT_REACTION_UNSPECIFIED" => UltravoxV1CallToolDefaultReaction.AgentReactionUnspecified,
                _ => null,
            };
        }
    }
}
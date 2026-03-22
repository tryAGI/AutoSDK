//HintName: G.Models.UltravoxV1BaseToolDefinitionDefaultReaction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates the default for how the agent should proceed after the tool is invoked.<br/>
    ///  Can be overridden by the tool implementation via the X-Ultravox-Agent-Reaction<br/>
    ///  header.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UltravoxV1BaseToolDefinitionDefaultReaction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AGENT_REACTION_LISTENS")]
        AgentReactionListens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AGENT_REACTION_SPEAKS")]
        AgentReactionSpeaks,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AGENT_REACTION_SPEAKS_ONCE")]
        AgentReactionSpeaksOnce,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AGENT_REACTION_UNSPECIFIED")]
        AgentReactionUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UltravoxV1BaseToolDefinitionDefaultReactionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UltravoxV1BaseToolDefinitionDefaultReaction value)
        {
            return value switch
            {
                UltravoxV1BaseToolDefinitionDefaultReaction.AgentReactionListens => "AGENT_REACTION_LISTENS",
                UltravoxV1BaseToolDefinitionDefaultReaction.AgentReactionSpeaks => "AGENT_REACTION_SPEAKS",
                UltravoxV1BaseToolDefinitionDefaultReaction.AgentReactionSpeaksOnce => "AGENT_REACTION_SPEAKS_ONCE",
                UltravoxV1BaseToolDefinitionDefaultReaction.AgentReactionUnspecified => "AGENT_REACTION_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UltravoxV1BaseToolDefinitionDefaultReaction? ToEnum(string value)
        {
            return value switch
            {
                "AGENT_REACTION_LISTENS" => UltravoxV1BaseToolDefinitionDefaultReaction.AgentReactionListens,
                "AGENT_REACTION_SPEAKS" => UltravoxV1BaseToolDefinitionDefaultReaction.AgentReactionSpeaks,
                "AGENT_REACTION_SPEAKS_ONCE" => UltravoxV1BaseToolDefinitionDefaultReaction.AgentReactionSpeaksOnce,
                "AGENT_REACTION_UNSPECIFIED" => UltravoxV1BaseToolDefinitionDefaultReaction.AgentReactionUnspecified,
                _ => null,
            };
        }
    }
}
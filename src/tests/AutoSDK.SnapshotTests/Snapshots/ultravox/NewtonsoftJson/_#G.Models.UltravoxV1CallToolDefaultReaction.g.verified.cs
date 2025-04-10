//HintName: G.Models.UltravoxV1CallToolDefaultReaction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indicates the default for how the agent should proceed after the tool is invoked.<br/>
    ///  Can be overridden by the tool implementation via the X-Ultravox-Agent-Reaction<br/>
    ///  header.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UltravoxV1CallToolDefaultReaction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AGENT_REACTION_UNSPECIFIED")]
        AGENTREACTIONUNSPECIFIED,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AGENT_REACTION_SPEAKS")]
        AGENTREACTIONSPEAKS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AGENT_REACTION_LISTENS")]
        AGENTREACTIONLISTENS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AGENT_REACTION_SPEAKS_ONCE")]
        AGENTREACTIONSPEAKSONCE,
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
                UltravoxV1CallToolDefaultReaction.AGENTREACTIONUNSPECIFIED => "AGENT_REACTION_UNSPECIFIED",
                UltravoxV1CallToolDefaultReaction.AGENTREACTIONSPEAKS => "AGENT_REACTION_SPEAKS",
                UltravoxV1CallToolDefaultReaction.AGENTREACTIONLISTENS => "AGENT_REACTION_LISTENS",
                UltravoxV1CallToolDefaultReaction.AGENTREACTIONSPEAKSONCE => "AGENT_REACTION_SPEAKS_ONCE",
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
                "AGENT_REACTION_UNSPECIFIED" => UltravoxV1CallToolDefaultReaction.AGENTREACTIONUNSPECIFIED,
                "AGENT_REACTION_SPEAKS" => UltravoxV1CallToolDefaultReaction.AGENTREACTIONSPEAKS,
                "AGENT_REACTION_LISTENS" => UltravoxV1CallToolDefaultReaction.AGENTREACTIONLISTENS,
                "AGENT_REACTION_SPEAKS_ONCE" => UltravoxV1CallToolDefaultReaction.AGENTREACTIONSPEAKSONCE,
                _ => null,
            };
        }
    }
}
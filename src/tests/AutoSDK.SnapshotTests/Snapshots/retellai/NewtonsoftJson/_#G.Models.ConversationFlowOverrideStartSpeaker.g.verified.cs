//HintName: G.Models.ConversationFlowOverrideStartSpeaker.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Who starts the conversation - user or agent.<br/>
    /// Example: agent
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationFlowOverrideStartSpeaker
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent")]
        Agent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationFlowOverrideStartSpeakerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationFlowOverrideStartSpeaker value)
        {
            return value switch
            {
                ConversationFlowOverrideStartSpeaker.Agent => "agent",
                ConversationFlowOverrideStartSpeaker.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationFlowOverrideStartSpeaker? ToEnum(string value)
        {
            return value switch
            {
                "agent" => ConversationFlowOverrideStartSpeaker.Agent,
                "user" => ConversationFlowOverrideStartSpeaker.User,
                _ => null,
            };
        }
    }
}
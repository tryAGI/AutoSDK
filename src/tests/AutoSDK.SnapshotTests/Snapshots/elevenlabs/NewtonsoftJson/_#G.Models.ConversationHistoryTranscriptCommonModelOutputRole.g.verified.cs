//HintName: G.Models.ConversationHistoryTranscriptCommonModelOutputRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistoryTranscriptCommonModelOutputRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="agent")]
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptCommonModelOutputRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptCommonModelOutputRole value)
        {
            return value switch
            {
                ConversationHistoryTranscriptCommonModelOutputRole.User => "user",
                ConversationHistoryTranscriptCommonModelOutputRole.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptCommonModelOutputRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ConversationHistoryTranscriptCommonModelOutputRole.User,
                "agent" => ConversationHistoryTranscriptCommonModelOutputRole.Agent,
                _ => null,
            };
        }
    }
}
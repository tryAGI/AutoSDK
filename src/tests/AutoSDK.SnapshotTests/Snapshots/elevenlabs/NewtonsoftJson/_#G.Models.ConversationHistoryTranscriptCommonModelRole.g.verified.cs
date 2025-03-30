//HintName: G.Models.ConversationHistoryTranscriptCommonModelRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistoryTranscriptCommonModelRole
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
    public static class ConversationHistoryTranscriptCommonModelRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptCommonModelRole value)
        {
            return value switch
            {
                ConversationHistoryTranscriptCommonModelRole.User => "user",
                ConversationHistoryTranscriptCommonModelRole.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptCommonModelRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ConversationHistoryTranscriptCommonModelRole.User,
                "agent" => ConversationHistoryTranscriptCommonModelRole.Agent,
                _ => null,
            };
        }
    }
}
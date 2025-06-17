//HintName: G.Models.ConversationHistoryTranscriptCommonModelInputRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationHistoryTranscriptCommonModelInputRole
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
    public static class ConversationHistoryTranscriptCommonModelInputRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptCommonModelInputRole value)
        {
            return value switch
            {
                ConversationHistoryTranscriptCommonModelInputRole.User => "user",
                ConversationHistoryTranscriptCommonModelInputRole.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptCommonModelInputRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ConversationHistoryTranscriptCommonModelInputRole.User,
                "agent" => ConversationHistoryTranscriptCommonModelInputRole.Agent,
                _ => null,
            };
        }
    }
}
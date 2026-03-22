//HintName: G.Models.ConversationHistoryTranscriptCommonModelInputRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTranscriptCommonModelInputRole
    {
        /// <summary>
        /// 
        /// </summary>
        Agent,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                ConversationHistoryTranscriptCommonModelInputRole.Agent => "agent",
                ConversationHistoryTranscriptCommonModelInputRole.User => "user",
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
                "agent" => ConversationHistoryTranscriptCommonModelInputRole.Agent,
                "user" => ConversationHistoryTranscriptCommonModelInputRole.User,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ConversationHistoryTranscriptResponseModelRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConversationHistoryTranscriptResponseModelRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Agent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationHistoryTranscriptResponseModelRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationHistoryTranscriptResponseModelRole value)
        {
            return value switch
            {
                ConversationHistoryTranscriptResponseModelRole.User => "user",
                ConversationHistoryTranscriptResponseModelRole.Agent => "agent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationHistoryTranscriptResponseModelRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => ConversationHistoryTranscriptResponseModelRole.User,
                "agent" => ConversationHistoryTranscriptResponseModelRole.Agent,
                _ => null,
            };
        }
    }
}
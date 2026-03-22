//HintName: G.Models.RealtimeConversationItemWithReferenceRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message sender (`user`, `assistant`, `system`), only <br/>
    /// applicable for `message` items.
    /// </summary>
    public enum RealtimeConversationItemWithReferenceRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemWithReferenceRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemWithReferenceRole value)
        {
            return value switch
            {
                RealtimeConversationItemWithReferenceRole.Assistant => "assistant",
                RealtimeConversationItemWithReferenceRole.System => "system",
                RealtimeConversationItemWithReferenceRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemWithReferenceRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => RealtimeConversationItemWithReferenceRole.Assistant,
                "system" => RealtimeConversationItemWithReferenceRole.System,
                "user" => RealtimeConversationItemWithReferenceRole.User,
                _ => null,
            };
        }
    }
}
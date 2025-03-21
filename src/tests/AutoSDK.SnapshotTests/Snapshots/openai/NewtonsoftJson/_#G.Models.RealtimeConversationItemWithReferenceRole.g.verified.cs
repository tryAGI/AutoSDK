//HintName: G.Models.RealtimeConversationItemWithReferenceRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message sender (`user`, `assistant`, `system`), only <br/>
    /// applicable for `message` items.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RealtimeConversationItemWithReferenceRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
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
                RealtimeConversationItemWithReferenceRole.User => "user",
                RealtimeConversationItemWithReferenceRole.Assistant => "assistant",
                RealtimeConversationItemWithReferenceRole.System => "system",
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
                "user" => RealtimeConversationItemWithReferenceRole.User,
                "assistant" => RealtimeConversationItemWithReferenceRole.Assistant,
                "system" => RealtimeConversationItemWithReferenceRole.System,
                _ => null,
            };
        }
    }
}
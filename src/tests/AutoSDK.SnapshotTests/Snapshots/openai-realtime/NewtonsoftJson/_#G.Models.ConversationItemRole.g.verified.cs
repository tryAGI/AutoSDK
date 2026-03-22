//HintName: G.Models.ConversationItemRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message sender.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationItemRole
    {
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationItemRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemRole value)
        {
            return value switch
            {
                ConversationItemRole.Assistant => "assistant",
                ConversationItemRole.System => "system",
                ConversationItemRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ConversationItemRole.Assistant,
                "system" => ConversationItemRole.System,
                "user" => ConversationItemRole.User,
                _ => null,
            };
        }
    }
}
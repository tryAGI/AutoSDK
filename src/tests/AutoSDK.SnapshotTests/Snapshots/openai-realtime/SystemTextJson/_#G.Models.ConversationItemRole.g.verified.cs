//HintName: G.Models.ConversationItemRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message sender.
    /// </summary>
    public enum ConversationItemRole
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
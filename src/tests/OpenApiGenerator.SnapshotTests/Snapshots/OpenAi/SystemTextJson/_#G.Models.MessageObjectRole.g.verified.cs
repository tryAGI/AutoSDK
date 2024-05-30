//HintName: G.Models.MessageObjectRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The entity that produced the message. One of `user` or `assistant`.
    /// </summary>
    public enum MessageObjectRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    public static class MessageObjectRoleExtensions
    {
        public static string ToValueString(this MessageObjectRole value)
        {
            return value switch
            {
                MessageObjectRole.User => "user",
                MessageObjectRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageObjectRole ToEnum(string value)
        {
            return value switch
            {
                "user" => MessageObjectRole.User,
                "assistant" => MessageObjectRole.Assistant,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageObjectRole ToEnum(int value)
        {
            return value switch
            {
                0 => MessageObjectRole.User,
                1 => MessageObjectRole.Assistant,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
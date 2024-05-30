//HintName: G.Models.MessageDeltaObjectDeltaRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The entity that produced the message. One of `user` or `assistant`.
    /// </summary>
    public enum MessageDeltaObjectDeltaRole
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

    public static class MessageDeltaObjectDeltaRoleExtensions
    {
        public static string ToValueString(this MessageDeltaObjectDeltaRole value)
        {
            return value switch
            {
                MessageDeltaObjectDeltaRole.User => "user",
                MessageDeltaObjectDeltaRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaObjectDeltaRole ToEnum(string value)
        {
            return value switch
            {
                "user" => MessageDeltaObjectDeltaRole.User,
                "assistant" => MessageDeltaObjectDeltaRole.Assistant,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaObjectDeltaRole ToEnum(int value)
        {
            return value switch
            {
                0 => MessageDeltaObjectDeltaRole.User,
                1 => MessageDeltaObjectDeltaRole.Assistant,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
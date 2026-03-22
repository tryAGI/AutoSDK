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
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeltaObjectDeltaRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeltaObjectDeltaRole value)
        {
            return value switch
            {
                MessageDeltaObjectDeltaRole.Assistant => "assistant",
                MessageDeltaObjectDeltaRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaObjectDeltaRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessageDeltaObjectDeltaRole.Assistant,
                "user" => MessageDeltaObjectDeltaRole.User,
                _ => null,
            };
        }
    }
}
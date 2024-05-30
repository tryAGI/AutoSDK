//HintName: G.Models.MessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message
    /// </summary>
    public enum MessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    public static class MessageRoleExtensions
    {
        public static string ToValueString(this MessageRole value)
        {
            return value switch
            {
                MessageRole.System => "system",
                MessageRole.User => "user",
                MessageRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageRole ToEnum(string value)
        {
            return value switch
            {
                "system" => MessageRole.System,
                "user" => MessageRole.User,
                "assistant" => MessageRole.Assistant,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageRole ToEnum(int value)
        {
            return value switch
            {
                0 => MessageRole.System,
                1 => MessageRole.User,
                2 => MessageRole.Assistant,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
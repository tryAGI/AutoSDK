//HintName: G.Models.ChatMessageOutputRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message author.
    /// </summary>
    public enum ChatMessageOutputRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageOutputRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageOutputRole value)
        {
            return value switch
            {
                ChatMessageOutputRole.Assistant => "assistant",
                ChatMessageOutputRole.Tool => "tool",
                ChatMessageOutputRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageOutputRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatMessageOutputRole.Assistant,
                "tool" => ChatMessageOutputRole.Tool,
                "user" => ChatMessageOutputRole.User,
                _ => null,
            };
        }
    }
}
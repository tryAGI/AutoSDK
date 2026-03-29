//HintName: G.Models.ChatMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: apiMessage
    /// </summary>
    public enum ChatMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        ApiMessage,
        /// <summary>
        /// 
        /// </summary>
        UserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageRole value)
        {
            return value switch
            {
                ChatMessageRole.ApiMessage => "apiMessage",
                ChatMessageRole.UserMessage => "userMessage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "apiMessage" => ChatMessageRole.ApiMessage,
                "userMessage" => ChatMessageRole.UserMessage,
                _ => null,
            };
        }
    }
}
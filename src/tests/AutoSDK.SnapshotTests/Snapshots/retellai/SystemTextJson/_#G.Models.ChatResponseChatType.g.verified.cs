//HintName: G.Models.ChatResponseChatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the chat<br/>
    /// Example: api_chat
    /// </summary>
    public enum ChatResponseChatType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiChat,
        /// <summary>
        /// 
        /// </summary>
        SmsChat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatResponseChatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatResponseChatType value)
        {
            return value switch
            {
                ChatResponseChatType.ApiChat => "api_chat",
                ChatResponseChatType.SmsChat => "sms_chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatResponseChatType? ToEnum(string value)
        {
            return value switch
            {
                "api_chat" => ChatResponseChatType.ApiChat,
                "sms_chat" => ChatResponseChatType.SmsChat,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ChatRequestChatMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatRequestChatMode
    {
        /// <summary>
        /// 
        /// </summary>
        Functional,
        /// <summary>
        /// 
        /// </summary>
        Maintenance,
        /// <summary>
        /// 
        /// </summary>
        Playground,
        /// <summary>
        /// 
        /// </summary>
        TextOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatRequestChatModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatRequestChatMode value)
        {
            return value switch
            {
                ChatRequestChatMode.Functional => "Functional",
                ChatRequestChatMode.Maintenance => "Maintenance",
                ChatRequestChatMode.Playground => "Playground",
                ChatRequestChatMode.TextOnly => "TextOnly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatRequestChatMode? ToEnum(string value)
        {
            return value switch
            {
                "Functional" => ChatRequestChatMode.Functional,
                "Maintenance" => ChatRequestChatMode.Maintenance,
                "Playground" => ChatRequestChatMode.Playground,
                "TextOnly" => ChatRequestChatMode.TextOnly,
                _ => null,
            };
        }
    }
}
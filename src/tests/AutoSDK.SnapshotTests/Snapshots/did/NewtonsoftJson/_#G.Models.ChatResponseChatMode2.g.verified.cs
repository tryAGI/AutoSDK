//HintName: G.Models.ChatResponseChatMode2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatResponseChatMode2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Functional")]
        Functional,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Maintenance")]
        Maintenance,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Playground")]
        Playground,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TextOnly")]
        TextOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatResponseChatMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatResponseChatMode2 value)
        {
            return value switch
            {
                ChatResponseChatMode2.Functional => "Functional",
                ChatResponseChatMode2.Maintenance => "Maintenance",
                ChatResponseChatMode2.Playground => "Playground",
                ChatResponseChatMode2.TextOnly => "TextOnly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatResponseChatMode2? ToEnum(string value)
        {
            return value switch
            {
                "Functional" => ChatResponseChatMode2.Functional,
                "Maintenance" => ChatResponseChatMode2.Maintenance,
                "Playground" => ChatResponseChatMode2.Playground,
                "TextOnly" => ChatResponseChatMode2.TextOnly,
                _ => null,
            };
        }
    }
}
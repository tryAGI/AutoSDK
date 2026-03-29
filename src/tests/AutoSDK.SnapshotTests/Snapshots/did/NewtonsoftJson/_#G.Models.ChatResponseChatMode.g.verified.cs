//HintName: G.Models.ChatResponseChatMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatResponseChatMode
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
    public static class ChatResponseChatModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatResponseChatMode value)
        {
            return value switch
            {
                ChatResponseChatMode.Functional => "Functional",
                ChatResponseChatMode.Maintenance => "Maintenance",
                ChatResponseChatMode.Playground => "Playground",
                ChatResponseChatMode.TextOnly => "TextOnly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatResponseChatMode? ToEnum(string value)
        {
            return value switch
            {
                "Functional" => ChatResponseChatMode.Functional,
                "Maintenance" => ChatResponseChatMode.Maintenance,
                "Playground" => ChatResponseChatMode.Playground,
                "TextOnly" => ChatResponseChatMode.TextOnly,
                _ => null,
            };
        }
    }
}
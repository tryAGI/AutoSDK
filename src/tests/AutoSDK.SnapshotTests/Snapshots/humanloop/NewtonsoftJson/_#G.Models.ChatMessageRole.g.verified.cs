//HintName: G.Models.ChatMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Role of the message author.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tool")]
        Tool,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
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
                ChatMessageRole.Assistant => "assistant",
                ChatMessageRole.System => "system",
                ChatMessageRole.Tool => "tool",
                ChatMessageRole.User => "user",
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
                "assistant" => ChatMessageRole.Assistant,
                "system" => ChatMessageRole.System,
                "tool" => ChatMessageRole.Tool,
                "user" => ChatMessageRole.User,
                _ => null,
            };
        }
    }
}
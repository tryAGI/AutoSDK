//HintName: G.Models.ChatMessageRequestRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the chat message. You can provide a system prompt by setting the role to `system`, or specify that a message is the result of a [tool call](https://dev.writer.com/home/tool-calling) by setting the role to `tool`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatMessageRequestRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// //dev.writer.com/home/tool-calling) by setting the role to `tool`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// //dev.writer.com/home/tool-calling) by setting the role to `tool`.
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
    public static class ChatMessageRequestRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageRequestRole value)
        {
            return value switch
            {
                ChatMessageRequestRole.Assistant => "assistant",
                ChatMessageRequestRole.System => "system",
                ChatMessageRequestRole.Tool => "tool",
                ChatMessageRequestRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageRequestRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatMessageRequestRole.Assistant,
                "system" => ChatMessageRequestRole.System,
                "tool" => ChatMessageRequestRole.Tool,
                "user" => ChatMessageRequestRole.User,
                _ => null,
            };
        }
    }
}
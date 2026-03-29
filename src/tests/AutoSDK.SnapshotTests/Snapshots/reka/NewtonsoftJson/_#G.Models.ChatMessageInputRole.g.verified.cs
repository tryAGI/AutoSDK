//HintName: G.Models.ChatMessageInputRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message author.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatMessageInputRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
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
    public static class ChatMessageInputRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageInputRole value)
        {
            return value switch
            {
                ChatMessageInputRole.Assistant => "assistant",
                ChatMessageInputRole.Tool => "tool",
                ChatMessageInputRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageInputRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatMessageInputRole.Assistant,
                "tool" => ChatMessageInputRole.Tool,
                "user" => ChatMessageInputRole.User,
                _ => null,
            };
        }
    }
}
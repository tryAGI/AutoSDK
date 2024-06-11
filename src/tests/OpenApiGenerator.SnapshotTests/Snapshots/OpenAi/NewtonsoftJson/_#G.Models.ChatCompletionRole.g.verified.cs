//HintName: G.Models.ChatCompletionRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the author of a message
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
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
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRole value)
        {
            return value switch
            {
                ChatCompletionRole.System => "system",
                ChatCompletionRole.User => "user",
                ChatCompletionRole.Assistant => "assistant",
                ChatCompletionRole.Tool => "tool",
                ChatCompletionRole.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => ChatCompletionRole.System,
                "user" => ChatCompletionRole.User,
                "assistant" => ChatCompletionRole.Assistant,
                "tool" => ChatCompletionRole.Tool,
                "function" => ChatCompletionRole.Function,
                _ => null,
            };
        }
    }
}
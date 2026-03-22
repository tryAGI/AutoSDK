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
        [global::System.Runtime.Serialization.EnumMember(Value="assistant")]
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="developer")]
        Developer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
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
    public static class ChatCompletionRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRole value)
        {
            return value switch
            {
                ChatCompletionRole.Assistant => "assistant",
                ChatCompletionRole.Developer => "developer",
                ChatCompletionRole.Function => "function",
                ChatCompletionRole.System => "system",
                ChatCompletionRole.Tool => "tool",
                ChatCompletionRole.User => "user",
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
                "assistant" => ChatCompletionRole.Assistant,
                "developer" => ChatCompletionRole.Developer,
                "function" => ChatCompletionRole.Function,
                "system" => ChatCompletionRole.System,
                "tool" => ChatCompletionRole.Tool,
                "user" => ChatCompletionRole.User,
                _ => null,
            };
        }
    }
}
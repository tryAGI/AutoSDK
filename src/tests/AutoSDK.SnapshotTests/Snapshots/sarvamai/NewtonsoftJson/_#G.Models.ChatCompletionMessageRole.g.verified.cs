//HintName: G.Models.ChatCompletionMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the message author
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionMessageRole
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
    public static class ChatCompletionMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageRole value)
        {
            return value switch
            {
                ChatCompletionMessageRole.Assistant => "assistant",
                ChatCompletionMessageRole.System => "system",
                ChatCompletionMessageRole.Tool => "tool",
                ChatCompletionMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionMessageRole.Assistant,
                "system" => ChatCompletionMessageRole.System,
                "tool" => ChatCompletionMessageRole.Tool,
                "user" => ChatCompletionMessageRole.User,
                _ => null,
            };
        }
    }
}
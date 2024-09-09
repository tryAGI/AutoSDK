//HintName: G.Models.ChatCompletionRequestMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the messages author. Choice between: system, user, or assistant.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionRequestMessageRole
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestMessageRole value)
        {
            return value switch
            {
                ChatCompletionRequestMessageRole.System => "system",
                ChatCompletionRequestMessageRole.User => "user",
                ChatCompletionRequestMessageRole.Assistant => "assistant",
                ChatCompletionRequestMessageRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "system" => ChatCompletionRequestMessageRole.System,
                "user" => ChatCompletionRequestMessageRole.User,
                "assistant" => ChatCompletionRequestMessageRole.Assistant,
                "tool" => ChatCompletionRequestMessageRole.Tool,
                _ => null,
            };
        }
    }
}
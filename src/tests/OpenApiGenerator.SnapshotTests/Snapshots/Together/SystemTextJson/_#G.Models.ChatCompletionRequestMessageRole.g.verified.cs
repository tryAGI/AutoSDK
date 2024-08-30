//HintName: G.Models.ChatCompletionRequestMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the messages author. Choice between: system, user, or assistant.
    /// </summary>
    public enum ChatCompletionRequestMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
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
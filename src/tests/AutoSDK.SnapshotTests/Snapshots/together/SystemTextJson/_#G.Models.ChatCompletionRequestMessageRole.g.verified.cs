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
        /// system, user, or assistant.
        /// </summary>
        Assistant,
        /// <summary>
        /// system, user, or assistant.
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// system, user, or assistant.
        /// </summary>
        User,
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
                ChatCompletionRequestMessageRole.Assistant => "assistant",
                ChatCompletionRequestMessageRole.System => "system",
                ChatCompletionRequestMessageRole.Tool => "tool",
                ChatCompletionRequestMessageRole.User => "user",
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
                "assistant" => ChatCompletionRequestMessageRole.Assistant,
                "system" => ChatCompletionRequestMessageRole.System,
                "tool" => ChatCompletionRequestMessageRole.Tool,
                "user" => ChatCompletionRequestMessageRole.User,
                _ => null,
            };
        }
    }
}
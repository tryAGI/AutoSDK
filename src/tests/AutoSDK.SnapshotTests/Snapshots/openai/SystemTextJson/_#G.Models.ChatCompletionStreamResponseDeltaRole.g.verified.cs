//HintName: G.Models.ChatCompletionStreamResponseDeltaRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the author of this message.
    /// </summary>
    public enum ChatCompletionStreamResponseDeltaRole
    {
        /// <summary>
        /// 
        /// </summary>
        Developer,
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
    public static class ChatCompletionStreamResponseDeltaRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionStreamResponseDeltaRole value)
        {
            return value switch
            {
                ChatCompletionStreamResponseDeltaRole.Developer => "developer",
                ChatCompletionStreamResponseDeltaRole.System => "system",
                ChatCompletionStreamResponseDeltaRole.User => "user",
                ChatCompletionStreamResponseDeltaRole.Assistant => "assistant",
                ChatCompletionStreamResponseDeltaRole.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionStreamResponseDeltaRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => ChatCompletionStreamResponseDeltaRole.Developer,
                "system" => ChatCompletionStreamResponseDeltaRole.System,
                "user" => ChatCompletionStreamResponseDeltaRole.User,
                "assistant" => ChatCompletionStreamResponseDeltaRole.Assistant,
                "tool" => ChatCompletionStreamResponseDeltaRole.Tool,
                _ => null,
            };
        }
    }
}
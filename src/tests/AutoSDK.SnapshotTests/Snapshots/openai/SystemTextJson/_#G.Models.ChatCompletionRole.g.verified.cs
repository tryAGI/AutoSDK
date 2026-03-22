//HintName: G.Models.ChatCompletionRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The role of the author of a message
    /// </summary>
    public enum ChatCompletionRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
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
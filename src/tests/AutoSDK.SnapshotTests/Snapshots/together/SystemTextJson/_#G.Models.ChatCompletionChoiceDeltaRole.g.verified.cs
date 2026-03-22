//HintName: G.Models.ChatCompletionChoiceDeltaRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionChoiceDeltaRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
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
    public static class ChatCompletionChoiceDeltaRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionChoiceDeltaRole value)
        {
            return value switch
            {
                ChatCompletionChoiceDeltaRole.Assistant => "assistant",
                ChatCompletionChoiceDeltaRole.Function => "function",
                ChatCompletionChoiceDeltaRole.System => "system",
                ChatCompletionChoiceDeltaRole.Tool => "tool",
                ChatCompletionChoiceDeltaRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionChoiceDeltaRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionChoiceDeltaRole.Assistant,
                "function" => ChatCompletionChoiceDeltaRole.Function,
                "system" => ChatCompletionChoiceDeltaRole.System,
                "tool" => ChatCompletionChoiceDeltaRole.Tool,
                "user" => ChatCompletionChoiceDeltaRole.User,
                _ => null,
            };
        }
    }
}
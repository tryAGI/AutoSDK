//HintName: G.Models.ChatCompletionChunkChoiceDeltaRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionChunkChoiceDeltaRole
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
    public static class ChatCompletionChunkChoiceDeltaRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionChunkChoiceDeltaRole value)
        {
            return value switch
            {
                ChatCompletionChunkChoiceDeltaRole.Assistant => "assistant",
                ChatCompletionChunkChoiceDeltaRole.Function => "function",
                ChatCompletionChunkChoiceDeltaRole.System => "system",
                ChatCompletionChunkChoiceDeltaRole.Tool => "tool",
                ChatCompletionChunkChoiceDeltaRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionChunkChoiceDeltaRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionChunkChoiceDeltaRole.Assistant,
                "function" => ChatCompletionChunkChoiceDeltaRole.Function,
                "system" => ChatCompletionChunkChoiceDeltaRole.System,
                "tool" => ChatCompletionChunkChoiceDeltaRole.Tool,
                "user" => ChatCompletionChunkChoiceDeltaRole.User,
                _ => null,
            };
        }
    }
}
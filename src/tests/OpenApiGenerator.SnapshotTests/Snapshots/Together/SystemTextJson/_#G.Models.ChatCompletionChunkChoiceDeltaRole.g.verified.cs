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
        Function,
        /// <summary>
        /// 
        /// </summary>
        Tool,
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
                ChatCompletionChunkChoiceDeltaRole.System => "system",
                ChatCompletionChunkChoiceDeltaRole.User => "user",
                ChatCompletionChunkChoiceDeltaRole.Assistant => "assistant",
                ChatCompletionChunkChoiceDeltaRole.Function => "function",
                ChatCompletionChunkChoiceDeltaRole.Tool => "tool",
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
                "system" => ChatCompletionChunkChoiceDeltaRole.System,
                "user" => ChatCompletionChunkChoiceDeltaRole.User,
                "assistant" => ChatCompletionChunkChoiceDeltaRole.Assistant,
                "function" => ChatCompletionChunkChoiceDeltaRole.Function,
                "tool" => ChatCompletionChunkChoiceDeltaRole.Tool,
                _ => null,
            };
        }
    }
}
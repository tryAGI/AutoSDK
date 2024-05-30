//HintName: G.Models.ChatCompletionMessageToolCallChunkType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool. Currently, only `function` is supported.
    /// </summary>
    public enum ChatCompletionMessageToolCallChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    public static class ChatCompletionMessageToolCallChunkTypeExtensions
    {
        public static string ToValueString(this ChatCompletionMessageToolCallChunkType value)
        {
            return value switch
            {
                ChatCompletionMessageToolCallChunkType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionMessageToolCallChunkType ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionMessageToolCallChunkType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChatCompletionMessageToolCallChunkType ToEnum(int value)
        {
            return value switch
            {
                0 => ChatCompletionMessageToolCallChunkType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
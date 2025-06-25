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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageToolCallChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageToolCallChunkType value)
        {
            return value switch
            {
                ChatCompletionMessageToolCallChunkType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageToolCallChunkType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionMessageToolCallChunkType.Function,
                _ => null,
            };
        }
    }
}
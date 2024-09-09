//HintName: G.Models.ChatCompletionChunkObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionChunkObject
    {
        /// <summary>
        /// 
        /// </summary>
        ChatCompletionChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionChunkObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionChunkObject value)
        {
            return value switch
            {
                ChatCompletionChunkObject.ChatCompletionChunk => "chat.completion.chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionChunkObject? ToEnum(string value)
        {
            return value switch
            {
                "chat.completion.chunk" => ChatCompletionChunkObject.ChatCompletionChunk,
                _ => null,
            };
        }
    }
}
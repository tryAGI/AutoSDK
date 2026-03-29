//HintName: G.Models.ChatCompletionChunkResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, always "chat.completion.chunk".
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionChunkResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat.completion.chunk")]
        ChatCompletionChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionChunkResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionChunkResponseObject value)
        {
            return value switch
            {
                ChatCompletionChunkResponseObject.ChatCompletionChunk => "chat.completion.chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionChunkResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "chat.completion.chunk" => ChatCompletionChunkResponseObject.ChatCompletionChunk,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ChatMessageChunkType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: ChatMessageChunk
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatMessageChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ChatMessageChunk")]
        ChatMessageChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatMessageChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatMessageChunkType value)
        {
            return value switch
            {
                ChatMessageChunkType.ChatMessageChunk => "ChatMessageChunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatMessageChunkType? ToEnum(string value)
        {
            return value switch
            {
                "ChatMessageChunk" => ChatMessageChunkType.ChatMessageChunk,
                _ => null,
            };
        }
    }
}
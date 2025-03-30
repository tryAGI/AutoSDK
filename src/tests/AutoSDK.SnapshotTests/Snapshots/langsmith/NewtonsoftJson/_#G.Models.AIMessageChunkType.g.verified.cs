//HintName: G.Models.AIMessageChunkType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: AIMessageChunk
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AIMessageChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AIMessageChunk")]
        AIMessageChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AIMessageChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AIMessageChunkType value)
        {
            return value switch
            {
                AIMessageChunkType.AIMessageChunk => "AIMessageChunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AIMessageChunkType? ToEnum(string value)
        {
            return value switch
            {
                "AIMessageChunk" => AIMessageChunkType.AIMessageChunk,
                _ => null,
            };
        }
    }
}
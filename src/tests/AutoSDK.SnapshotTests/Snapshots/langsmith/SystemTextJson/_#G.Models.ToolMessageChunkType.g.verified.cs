//HintName: G.Models.ToolMessageChunkType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: ToolMessageChunk
    /// </summary>
    public enum ToolMessageChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolMessageChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolMessageChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolMessageChunkType value)
        {
            return value switch
            {
                ToolMessageChunkType.ToolMessageChunk => "ToolMessageChunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolMessageChunkType? ToEnum(string value)
        {
            return value switch
            {
                "ToolMessageChunk" => ToolMessageChunkType.ToolMessageChunk,
                _ => null,
            };
        }
    }
}
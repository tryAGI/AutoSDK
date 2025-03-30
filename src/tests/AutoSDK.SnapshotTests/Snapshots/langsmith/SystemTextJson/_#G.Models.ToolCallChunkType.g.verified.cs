//HintName: G.Models.ToolCallChunkType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolCallChunkType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolCallChunk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolCallChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolCallChunkType value)
        {
            return value switch
            {
                ToolCallChunkType.ToolCallChunk => "tool_call_chunk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolCallChunkType? ToEnum(string value)
        {
            return value switch
            {
                "tool_call_chunk" => ToolCallChunkType.ToolCallChunk,
                _ => null,
            };
        }
    }
}
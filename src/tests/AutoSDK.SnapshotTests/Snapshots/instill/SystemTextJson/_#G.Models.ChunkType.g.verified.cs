//HintName: G.Models.ChunkType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// - CHUNK_TYPE_TEXT: text<br/>
    ///  - CHUNK_TYPE_IMAGE: image<br/>
    ///  - CHUNK_TYPE_AUDIO: audio<br/>
    ///  - CHUNK_TYPE_VIDEO: video
    /// </summary>
    public enum ChunkType
    {
        /// <summary>
        /// text
        /// </summary>
        TEXT,
        /// <summary>
        /// image
        /// </summary>
        IMAGE,
        /// <summary>
        /// audio
        /// </summary>
        AUDIO,
        /// <summary>
        /// video
        /// </summary>
        VIDEO,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChunkTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChunkType value)
        {
            return value switch
            {
                ChunkType.TEXT => "CHUNK_TYPE_TEXT",
                ChunkType.IMAGE => "CHUNK_TYPE_IMAGE",
                ChunkType.AUDIO => "CHUNK_TYPE_AUDIO",
                ChunkType.VIDEO => "CHUNK_TYPE_VIDEO",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChunkType? ToEnum(string value)
        {
            return value switch
            {
                "CHUNK_TYPE_TEXT" => ChunkType.TEXT,
                "CHUNK_TYPE_IMAGE" => ChunkType.IMAGE,
                "CHUNK_TYPE_AUDIO" => ChunkType.AUDIO,
                "CHUNK_TYPE_VIDEO" => ChunkType.VIDEO,
                _ => null,
            };
        }
    }
}
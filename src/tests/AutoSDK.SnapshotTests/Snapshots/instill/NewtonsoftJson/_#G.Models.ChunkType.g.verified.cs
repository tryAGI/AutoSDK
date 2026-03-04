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
    [global::System.Runtime.Serialization.DataContract]
    public enum ChunkType
    {
        /// <summary>
        /// text
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CHUNK_TYPE_TEXT")]
        Text,
        /// <summary>
        /// image
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CHUNK_TYPE_IMAGE")]
        Image,
        /// <summary>
        /// audio
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CHUNK_TYPE_AUDIO")]
        Audio,
        /// <summary>
        /// video
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CHUNK_TYPE_VIDEO")]
        Video,
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
                ChunkType.Text => "CHUNK_TYPE_TEXT",
                ChunkType.Image => "CHUNK_TYPE_IMAGE",
                ChunkType.Audio => "CHUNK_TYPE_AUDIO",
                ChunkType.Video => "CHUNK_TYPE_VIDEO",
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
                "CHUNK_TYPE_TEXT" => ChunkType.Text,
                "CHUNK_TYPE_IMAGE" => ChunkType.Image,
                "CHUNK_TYPE_AUDIO" => ChunkType.Audio,
                "CHUNK_TYPE_VIDEO" => ChunkType.Video,
                _ => null,
            };
        }
    }
}
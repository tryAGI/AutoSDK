//HintName: G.Models.EmbeddingAudioMetadataInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingAudioMetadataInputType
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingAudioMetadataInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingAudioMetadataInputType value)
        {
            return value switch
            {
                EmbeddingAudioMetadataInputType.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingAudioMetadataInputType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => EmbeddingAudioMetadataInputType.Audio,
                _ => null,
            };
        }
    }
}
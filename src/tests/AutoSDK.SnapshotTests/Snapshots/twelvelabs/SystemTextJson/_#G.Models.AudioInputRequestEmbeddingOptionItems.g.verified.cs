//HintName: G.Models.AudioInputRequestEmbeddingOptionItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioInputRequestEmbeddingOptionItems
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Transcription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioInputRequestEmbeddingOptionItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioInputRequestEmbeddingOptionItems value)
        {
            return value switch
            {
                AudioInputRequestEmbeddingOptionItems.Audio => "audio",
                AudioInputRequestEmbeddingOptionItems.Transcription => "transcription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioInputRequestEmbeddingOptionItems? ToEnum(string value)
        {
            return value switch
            {
                "audio" => AudioInputRequestEmbeddingOptionItems.Audio,
                "transcription" => AudioInputRequestEmbeddingOptionItems.Transcription,
                _ => null,
            };
        }
    }
}
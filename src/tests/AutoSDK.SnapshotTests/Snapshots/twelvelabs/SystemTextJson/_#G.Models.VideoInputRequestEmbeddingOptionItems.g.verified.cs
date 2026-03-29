//HintName: G.Models.VideoInputRequestEmbeddingOptionItems.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VideoInputRequestEmbeddingOptionItems
    {
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Transcription,
        /// <summary>
        /// 
        /// </summary>
        Visual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoInputRequestEmbeddingOptionItemsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VideoInputRequestEmbeddingOptionItems value)
        {
            return value switch
            {
                VideoInputRequestEmbeddingOptionItems.Audio => "audio",
                VideoInputRequestEmbeddingOptionItems.Transcription => "transcription",
                VideoInputRequestEmbeddingOptionItems.Visual => "visual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoInputRequestEmbeddingOptionItems? ToEnum(string value)
        {
            return value switch
            {
                "audio" => VideoInputRequestEmbeddingOptionItems.Audio,
                "transcription" => VideoInputRequestEmbeddingOptionItems.Transcription,
                "visual" => VideoInputRequestEmbeddingOptionItems.Visual,
                _ => null,
            };
        }
    }
}
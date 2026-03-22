//HintName: G.Models.PendingClipTaskType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PendingClipTaskType
    {
        /// <summary>
        /// 
        /// </summary>
        Dubbing,
        /// <summary>
        /// 
        /// </summary>
        Preprocessing,
        /// <summary>
        /// 
        /// </summary>
        SpeechImport,
        /// <summary>
        /// 
        /// </summary>
        VideoToMusic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PendingClipTaskTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PendingClipTaskType value)
        {
            return value switch
            {
                PendingClipTaskType.Dubbing => "dubbing",
                PendingClipTaskType.Preprocessing => "preprocessing",
                PendingClipTaskType.SpeechImport => "speech_import",
                PendingClipTaskType.VideoToMusic => "video_to_music",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PendingClipTaskType? ToEnum(string value)
        {
            return value switch
            {
                "dubbing" => PendingClipTaskType.Dubbing,
                "preprocessing" => PendingClipTaskType.Preprocessing,
                "speech_import" => PendingClipTaskType.SpeechImport,
                "video_to_music" => PendingClipTaskType.VideoToMusic,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ImageGenerationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageGenerationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Generating,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationStatus value)
        {
            return value switch
            {
                ImageGenerationStatus.Completed => "completed",
                ImageGenerationStatus.Failed => "failed",
                ImageGenerationStatus.Generating => "generating",
                ImageGenerationStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ImageGenerationStatus.Completed,
                "failed" => ImageGenerationStatus.Failed,
                "generating" => ImageGenerationStatus.Generating,
                "in_progress" => ImageGenerationStatus.InProgress,
                _ => null,
            };
        }
    }
}
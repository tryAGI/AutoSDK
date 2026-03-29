//HintName: G.Models.ImageGenerationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageGenerationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failed")]
        Failed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generating")]
        Generating,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
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
//HintName: G.Models.ImageGenToolCallStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the image generation call.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageGenToolCallStatus
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
    public static class ImageGenToolCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenToolCallStatus value)
        {
            return value switch
            {
                ImageGenToolCallStatus.Completed => "completed",
                ImageGenToolCallStatus.Failed => "failed",
                ImageGenToolCallStatus.Generating => "generating",
                ImageGenToolCallStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenToolCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ImageGenToolCallStatus.Completed,
                "failed" => ImageGenToolCallStatus.Failed,
                "generating" => ImageGenToolCallStatus.Generating,
                "in_progress" => ImageGenToolCallStatus.InProgress,
                _ => null,
            };
        }
    }
}
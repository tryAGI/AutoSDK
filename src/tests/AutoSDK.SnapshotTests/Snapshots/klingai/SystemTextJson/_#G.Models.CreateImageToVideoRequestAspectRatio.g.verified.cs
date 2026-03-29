//HintName: G.Models.CreateImageToVideoRequestAspectRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aspect ratio of the output video.<br/>
    /// Default Value: 16:9
    /// </summary>
    public enum CreateImageToVideoRequestAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageToVideoRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageToVideoRequestAspectRatio value)
        {
            return value switch
            {
                CreateImageToVideoRequestAspectRatio.x16_9 => "16:9",
                CreateImageToVideoRequestAspectRatio.x1_1 => "1:1",
                CreateImageToVideoRequestAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageToVideoRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateImageToVideoRequestAspectRatio.x16_9,
                "1:1" => CreateImageToVideoRequestAspectRatio.x1_1,
                "9:16" => CreateImageToVideoRequestAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}
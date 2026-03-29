//HintName: G.Models.CreateVideoRequestAspectRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aspect ratio of the video. Default is `landscape (16:9)`.<br/>
    /// Default Value: 16:9
    /// </summary>
    public enum CreateVideoRequestAspectRatio
    {
        /// <summary>
        /// 9)`.
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x4_5,
        /// <summary>
        /// 
        /// </summary>
        x5_4,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVideoRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVideoRequestAspectRatio value)
        {
            return value switch
            {
                CreateVideoRequestAspectRatio.x16_9 => "16:9",
                CreateVideoRequestAspectRatio.x1_1 => "1:1",
                CreateVideoRequestAspectRatio.x4_5 => "4:5",
                CreateVideoRequestAspectRatio.x5_4 => "5:4",
                CreateVideoRequestAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVideoRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateVideoRequestAspectRatio.x16_9,
                "1:1" => CreateVideoRequestAspectRatio.x1_1,
                "4:5" => CreateVideoRequestAspectRatio.x4_5,
                "5:4" => CreateVideoRequestAspectRatio.x5_4,
                "9:16" => CreateVideoRequestAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}
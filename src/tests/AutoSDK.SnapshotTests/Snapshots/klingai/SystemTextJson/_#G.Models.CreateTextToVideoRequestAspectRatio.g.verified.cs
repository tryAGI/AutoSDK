//HintName: G.Models.CreateTextToVideoRequestAspectRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aspect ratio of the output video.<br/>
    /// Default Value: 16:9
    /// </summary>
    public enum CreateTextToVideoRequestAspectRatio
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
    public static class CreateTextToVideoRequestAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTextToVideoRequestAspectRatio value)
        {
            return value switch
            {
                CreateTextToVideoRequestAspectRatio.x16_9 => "16:9",
                CreateTextToVideoRequestAspectRatio.x1_1 => "1:1",
                CreateTextToVideoRequestAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTextToVideoRequestAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "16:9" => CreateTextToVideoRequestAspectRatio.x16_9,
                "1:1" => CreateTextToVideoRequestAspectRatio.x1_1,
                "9:16" => CreateTextToVideoRequestAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}
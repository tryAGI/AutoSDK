//HintName: G.Models.AspectRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// (Cannot be used in conjunction with resolution) The aspect ratio to use for image generation, which determines the image's resolution. Defaults to ASPECT_1_1.<br/>
    /// Example: ASPECT_10_16
    /// </summary>
    public enum AspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        Aspect1016,
        /// <summary>
        /// 
        /// </summary>
        Aspect1610,
        /// <summary>
        /// 
        /// </summary>
        Aspect169,
        /// <summary>
        /// 
        /// </summary>
        Aspect11,
        /// <summary>
        /// 
        /// </summary>
        Aspect13,
        /// <summary>
        /// 
        /// </summary>
        Aspect23,
        /// <summary>
        /// 
        /// </summary>
        Aspect31,
        /// <summary>
        /// 
        /// </summary>
        Aspect32,
        /// <summary>
        /// 
        /// </summary>
        Aspect34,
        /// <summary>
        /// 
        /// </summary>
        Aspect43,
        /// <summary>
        /// 
        /// </summary>
        Aspect916,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AspectRatio value)
        {
            return value switch
            {
                AspectRatio.Aspect1016 => "ASPECT_10_16",
                AspectRatio.Aspect1610 => "ASPECT_16_10",
                AspectRatio.Aspect169 => "ASPECT_16_9",
                AspectRatio.Aspect11 => "ASPECT_1_1",
                AspectRatio.Aspect13 => "ASPECT_1_3",
                AspectRatio.Aspect23 => "ASPECT_2_3",
                AspectRatio.Aspect31 => "ASPECT_3_1",
                AspectRatio.Aspect32 => "ASPECT_3_2",
                AspectRatio.Aspect34 => "ASPECT_3_4",
                AspectRatio.Aspect43 => "ASPECT_4_3",
                AspectRatio.Aspect916 => "ASPECT_9_16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "ASPECT_10_16" => AspectRatio.Aspect1016,
                "ASPECT_16_10" => AspectRatio.Aspect1610,
                "ASPECT_16_9" => AspectRatio.Aspect169,
                "ASPECT_1_1" => AspectRatio.Aspect11,
                "ASPECT_1_3" => AspectRatio.Aspect13,
                "ASPECT_2_3" => AspectRatio.Aspect23,
                "ASPECT_3_1" => AspectRatio.Aspect31,
                "ASPECT_3_2" => AspectRatio.Aspect32,
                "ASPECT_3_4" => AspectRatio.Aspect34,
                "ASPECT_4_3" => AspectRatio.Aspect43,
                "ASPECT_9_16" => AspectRatio.Aspect916,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.AspectRatio.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The aspect ratio of the generation<br/>
    /// Default Value: 16:9<br/>
    /// Example: 16:9
    /// </summary>
    public enum AspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
        /// <summary>
        /// 
        /// </summary>
        x4_3,
        /// <summary>
        /// 
        /// </summary>
        x3_4,
        /// <summary>
        /// 
        /// </summary>
        x21_9,
        /// <summary>
        /// 
        /// </summary>
        x9_21,
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
                AspectRatio.x1_1 => "1:1",
                AspectRatio.x16_9 => "16:9",
                AspectRatio.x9_16 => "9:16",
                AspectRatio.x4_3 => "4:3",
                AspectRatio.x3_4 => "3:4",
                AspectRatio.x21_9 => "21:9",
                AspectRatio.x9_21 => "9:21",
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
                "1:1" => AspectRatio.x1_1,
                "16:9" => AspectRatio.x16_9,
                "9:16" => AspectRatio.x9_16,
                "4:3" => AspectRatio.x4_3,
                "3:4" => AspectRatio.x3_4,
                "21:9" => AspectRatio.x21_9,
                "9:21" => AspectRatio.x9_21,
                _ => null,
            };
        }
    }
}
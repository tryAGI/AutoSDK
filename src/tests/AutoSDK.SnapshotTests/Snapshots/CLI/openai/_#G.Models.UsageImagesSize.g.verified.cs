//HintName: G.Models.UsageImagesSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageImagesSize
    {
        /// <summary>
        /// 
        /// </summary>
        x256x256,
        /// <summary>
        /// 
        /// </summary>
        x512x512,
        /// <summary>
        /// 
        /// </summary>
        x1024x1024,
        /// <summary>
        /// 
        /// </summary>
        x1792x1792,
        /// <summary>
        /// 
        /// </summary>
        x1024x1792,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageImagesSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageImagesSize value)
        {
            return value switch
            {
                UsageImagesSize.x256x256 => "256x256",
                UsageImagesSize.x512x512 => "512x512",
                UsageImagesSize.x1024x1024 => "1024x1024",
                UsageImagesSize.x1792x1792 => "1792x1792",
                UsageImagesSize.x1024x1792 => "1024x1792",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageImagesSize? ToEnum(string value)
        {
            return value switch
            {
                "256x256" => UsageImagesSize.x256x256,
                "512x512" => UsageImagesSize.x512x512,
                "1024x1024" => UsageImagesSize.x1024x1024,
                "1792x1792" => UsageImagesSize.x1792x1792,
                "1024x1792" => UsageImagesSize.x1024x1792,
                _ => null,
            };
        }
    }
}
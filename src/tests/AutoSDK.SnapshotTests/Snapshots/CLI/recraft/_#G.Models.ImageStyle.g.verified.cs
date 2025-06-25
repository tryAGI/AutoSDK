//HintName: G.Models.ImageStyle.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageStyle
    {
        /// <summary>
        /// 
        /// </summary>
        DigitalIllustration,
        /// <summary>
        /// 
        /// </summary>
        Icon,
        /// <summary>
        /// 
        /// </summary>
        RealisticImage,
        /// <summary>
        /// 
        /// </summary>
        VectorIllustration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageStyle value)
        {
            return value switch
            {
                ImageStyle.DigitalIllustration => "digital_illustration",
                ImageStyle.Icon => "icon",
                ImageStyle.RealisticImage => "realistic_image",
                ImageStyle.VectorIllustration => "vector_illustration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageStyle? ToEnum(string value)
        {
            return value switch
            {
                "digital_illustration" => ImageStyle.DigitalIllustration,
                "icon" => ImageStyle.Icon,
                "realistic_image" => ImageStyle.RealisticImage,
                "vector_illustration" => ImageStyle.VectorIllustration,
                _ => null,
            };
        }
    }
}
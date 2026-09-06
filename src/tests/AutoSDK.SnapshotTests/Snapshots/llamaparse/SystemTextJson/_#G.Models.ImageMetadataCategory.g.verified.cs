//HintName: G.Models.ImageMetadataCategory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageMetadataCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Embedded,
        /// <summary>
        /// 
        /// </summary>
        Layout,
        /// <summary>
        /// 
        /// </summary>
        Screenshot,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageMetadataCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageMetadataCategory value)
        {
            return value switch
            {
                ImageMetadataCategory.Embedded => "embedded",
                ImageMetadataCategory.Layout => "layout",
                ImageMetadataCategory.Screenshot => "screenshot",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageMetadataCategory? ToEnum(string value)
        {
            return value switch
            {
                "embedded" => ImageMetadataCategory.Embedded,
                "layout" => ImageMetadataCategory.Layout,
                "screenshot" => ImageMetadataCategory.Screenshot,
                _ => null,
            };
        }
    }
}
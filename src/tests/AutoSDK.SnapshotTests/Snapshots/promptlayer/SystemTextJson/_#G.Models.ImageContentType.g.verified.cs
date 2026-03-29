//HintName: G.Models.ImageContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: image_url
    /// </summary>
    public enum ImageContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageContentType value)
        {
            return value switch
            {
                ImageContentType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageContentType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ImageContentType.ImageUrl,
                _ => null,
            };
        }
    }
}
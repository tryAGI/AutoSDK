//HintName: G.Models.ImageBlockSourceMediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The media type of the image.
    /// </summary>
    public enum ImageBlockSourceMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageJpeg,
        /// <summary>
        /// 
        /// </summary>
        ImagePng,
        /// <summary>
        /// 
        /// </summary>
        ImageGif,
        /// <summary>
        /// 
        /// </summary>
        ImageWebp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageBlockSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageBlockSourceMediaType value)
        {
            return value switch
            {
                ImageBlockSourceMediaType.ImageJpeg => "image/jpeg",
                ImageBlockSourceMediaType.ImagePng => "image/png",
                ImageBlockSourceMediaType.ImageGif => "image/gif",
                ImageBlockSourceMediaType.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageBlockSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "image/jpeg" => ImageBlockSourceMediaType.ImageJpeg,
                "image/png" => ImageBlockSourceMediaType.ImagePng,
                "image/gif" => ImageBlockSourceMediaType.ImageGif,
                "image/webp" => ImageBlockSourceMediaType.ImageWebp,
                _ => null,
            };
        }
    }
}
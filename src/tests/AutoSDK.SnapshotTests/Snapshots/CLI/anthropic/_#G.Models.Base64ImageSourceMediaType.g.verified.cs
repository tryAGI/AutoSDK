//HintName: G.Models.Base64ImageSourceMediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Base64ImageSourceMediaType
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
    public static class Base64ImageSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Base64ImageSourceMediaType value)
        {
            return value switch
            {
                Base64ImageSourceMediaType.ImageJpeg => "image/jpeg",
                Base64ImageSourceMediaType.ImagePng => "image/png",
                Base64ImageSourceMediaType.ImageGif => "image/gif",
                Base64ImageSourceMediaType.ImageWebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Base64ImageSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "image/jpeg" => Base64ImageSourceMediaType.ImageJpeg,
                "image/png" => Base64ImageSourceMediaType.ImagePng,
                "image/gif" => Base64ImageSourceMediaType.ImageGif,
                "image/webp" => Base64ImageSourceMediaType.ImageWebp,
                _ => null,
            };
        }
    }
}
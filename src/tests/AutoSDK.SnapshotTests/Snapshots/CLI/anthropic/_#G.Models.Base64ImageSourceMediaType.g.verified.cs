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
        ImageDividegif,
        /// <summary>
        /// 
        /// </summary>
        ImageDividejpeg,
        /// <summary>
        /// 
        /// </summary>
        ImageDividepng,
        /// <summary>
        /// 
        /// </summary>
        ImageDividewebp,
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
                Base64ImageSourceMediaType.ImageDividegif => "image/gif",
                Base64ImageSourceMediaType.ImageDividejpeg => "image/jpeg",
                Base64ImageSourceMediaType.ImageDividepng => "image/png",
                Base64ImageSourceMediaType.ImageDividewebp => "image/webp",
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
                "image/gif" => Base64ImageSourceMediaType.ImageDividegif,
                "image/jpeg" => Base64ImageSourceMediaType.ImageDividejpeg,
                "image/png" => Base64ImageSourceMediaType.ImageDividepng,
                "image/webp" => Base64ImageSourceMediaType.ImageDividewebp,
                _ => null,
            };
        }
    }
}
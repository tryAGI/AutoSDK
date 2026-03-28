//HintName: G.Models.BetaBase64ImageSourceMediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaBase64ImageSourceMediaType
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
    public static class BetaBase64ImageSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBase64ImageSourceMediaType value)
        {
            return value switch
            {
                BetaBase64ImageSourceMediaType.ImageDividegif => "image/gif",
                BetaBase64ImageSourceMediaType.ImageDividejpeg => "image/jpeg",
                BetaBase64ImageSourceMediaType.ImageDividepng => "image/png",
                BetaBase64ImageSourceMediaType.ImageDividewebp => "image/webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBase64ImageSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "image/gif" => BetaBase64ImageSourceMediaType.ImageDividegif,
                "image/jpeg" => BetaBase64ImageSourceMediaType.ImageDividejpeg,
                "image/png" => BetaBase64ImageSourceMediaType.ImageDividepng,
                "image/webp" => BetaBase64ImageSourceMediaType.ImageDividewebp,
                _ => null,
            };
        }
    }
}
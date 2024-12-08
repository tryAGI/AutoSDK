//HintName: G.Models.BetaBase64ImageSourceMediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaBase64ImageSourceMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/jpeg")]
        ImageJpeg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/png")]
        ImagePng,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/gif")]
        ImageGif,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image/webp")]
        ImageWebp,
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
                BetaBase64ImageSourceMediaType.ImageJpeg => "image/jpeg",
                BetaBase64ImageSourceMediaType.ImagePng => "image/png",
                BetaBase64ImageSourceMediaType.ImageGif => "image/gif",
                BetaBase64ImageSourceMediaType.ImageWebp => "image/webp",
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
                "image/jpeg" => BetaBase64ImageSourceMediaType.ImageJpeg,
                "image/png" => BetaBase64ImageSourceMediaType.ImagePng,
                "image/gif" => BetaBase64ImageSourceMediaType.ImageGif,
                "image/webp" => BetaBase64ImageSourceMediaType.ImageWebp,
                _ => null,
            };
        }
    }
}
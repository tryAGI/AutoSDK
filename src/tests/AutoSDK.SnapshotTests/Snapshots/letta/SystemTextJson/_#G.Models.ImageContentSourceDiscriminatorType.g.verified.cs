//HintName: G.Models.ImageContentSourceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageContentSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        Letta,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageContentSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageContentSourceDiscriminatorType value)
        {
            return value switch
            {
                ImageContentSourceDiscriminatorType.Base64 => "base64",
                ImageContentSourceDiscriminatorType.Letta => "letta",
                ImageContentSourceDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageContentSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => ImageContentSourceDiscriminatorType.Base64,
                "letta" => ImageContentSourceDiscriminatorType.Letta,
                "url" => ImageContentSourceDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}
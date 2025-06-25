//HintName: G.Models.ImageAvatarType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the avatar<br/>
    /// Default Value: image
    /// </summary>
    public enum ImageAvatarType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageAvatarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageAvatarType value)
        {
            return value switch
            {
                ImageAvatarType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageAvatarType? ToEnum(string value)
        {
            return value switch
            {
                "image" => ImageAvatarType.Image,
                _ => null,
            };
        }
    }
}
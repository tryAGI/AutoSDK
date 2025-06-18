//HintName: G.Models.ImageGenToolBackground.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Background type for the generated image. One of `transparent`, <br/>
    /// `opaque`, or `auto`. Default: `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum ImageGenToolBackground
    {
        /// <summary>
        /// 
        /// </summary>
        Transparent,
        /// <summary>
        /// `auto`.
        /// </summary>
        Opaque,
        /// <summary>
        /// `auto`.
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenToolBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenToolBackground value)
        {
            return value switch
            {
                ImageGenToolBackground.Transparent => "transparent",
                ImageGenToolBackground.Opaque => "opaque",
                ImageGenToolBackground.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenToolBackground? ToEnum(string value)
        {
            return value switch
            {
                "transparent" => ImageGenToolBackground.Transparent,
                "opaque" => ImageGenToolBackground.Opaque,
                "auto" => ImageGenToolBackground.Auto,
                _ => null,
            };
        }
    }
}
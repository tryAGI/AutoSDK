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
        /// `auto`.
        /// </summary>
        Auto,
        /// <summary>
        /// `auto`.
        /// </summary>
        Opaque,
        /// <summary>
        /// 
        /// </summary>
        Transparent,
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
                ImageGenToolBackground.Auto => "auto",
                ImageGenToolBackground.Opaque => "opaque",
                ImageGenToolBackground.Transparent => "transparent",
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
                "auto" => ImageGenToolBackground.Auto,
                "opaque" => ImageGenToolBackground.Opaque,
                "transparent" => ImageGenToolBackground.Transparent,
                _ => null,
            };
        }
    }
}
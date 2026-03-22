//HintName: G.Models.ImageGenToolOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output format of the generated image. One of `png`, `webp`, or <br/>
    /// `jpeg`. Default: `png`.<br/>
    /// Default Value: png
    /// </summary>
    public enum ImageGenToolOutputFormat
    {
        /// <summary>
        /// `png`.
        /// </summary>
        Jpeg,
        /// <summary>
        /// `png`.
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenToolOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenToolOutputFormat value)
        {
            return value switch
            {
                ImageGenToolOutputFormat.Jpeg => "jpeg",
                ImageGenToolOutputFormat.Png => "png",
                ImageGenToolOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenToolOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => ImageGenToolOutputFormat.Jpeg,
                "png" => ImageGenToolOutputFormat.Png,
                "webp" => ImageGenToolOutputFormat.Webp,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ImageGenerationServerToolOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ImageGenerationServerToolOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Jpeg,
        /// <summary>
        /// 
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
    public static class ImageGenerationServerToolOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationServerToolOutputFormat value)
        {
            return value switch
            {
                ImageGenerationServerToolOutputFormat.Jpeg => "jpeg",
                ImageGenerationServerToolOutputFormat.Png => "png",
                ImageGenerationServerToolOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationServerToolOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "jpeg" => ImageGenerationServerToolOutputFormat.Jpeg,
                "png" => ImageGenerationServerToolOutputFormat.Png,
                "webp" => ImageGenerationServerToolOutputFormat.Webp,
                _ => null,
            };
        }
    }
}
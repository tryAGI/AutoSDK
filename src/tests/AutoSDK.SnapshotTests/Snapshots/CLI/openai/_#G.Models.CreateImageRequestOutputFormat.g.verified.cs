//HintName: G.Models.CreateImageRequestOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format in which the generated images are returned. This parameter is only supported for `gpt-image-1`. Must be one of `png`, `jpeg`, or `webp`.<br/>
    /// Default Value: png<br/>
    /// Example: png
    /// </summary>
    public enum CreateImageRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Jpeg,
        /// <summary>
        /// 
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestOutputFormat value)
        {
            return value switch
            {
                CreateImageRequestOutputFormat.Png => "png",
                CreateImageRequestOutputFormat.Jpeg => "jpeg",
                CreateImageRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "png" => CreateImageRequestOutputFormat.Png,
                "jpeg" => CreateImageRequestOutputFormat.Jpeg,
                "webp" => CreateImageRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}
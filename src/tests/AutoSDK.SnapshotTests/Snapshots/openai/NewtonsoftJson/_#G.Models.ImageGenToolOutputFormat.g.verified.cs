//HintName: G.Models.ImageGenToolOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The output format of the generated image. One of `png`, `webp`, or <br/>
    /// `jpeg`. Default: `png`.<br/>
    /// Default Value: png
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageGenToolOutputFormat
    {
        /// <summary>
        /// `png`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="png")]
        Png,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webp")]
        Webp,
        /// <summary>
        /// `png`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jpeg")]
        Jpeg,
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
                ImageGenToolOutputFormat.Png => "png",
                ImageGenToolOutputFormat.Webp => "webp",
                ImageGenToolOutputFormat.Jpeg => "jpeg",
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
                "png" => ImageGenToolOutputFormat.Png,
                "webp" => ImageGenToolOutputFormat.Webp,
                "jpeg" => ImageGenToolOutputFormat.Jpeg,
                _ => null,
            };
        }
    }
}
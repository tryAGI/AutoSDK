//HintName: G.Models.CreateImageEditRequestOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format in which the generated images are returned. This parameter is<br/>
    /// only supported for `gpt-image-1`. Must be one of `png`, `jpeg`, or `webp`.<br/>
    /// The default value is `png`.<br/>
    /// Default Value: png<br/>
    /// Example: png
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageEditRequestOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="png")]
        Png,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jpeg")]
        Jpeg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webp")]
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageEditRequestOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageEditRequestOutputFormat value)
        {
            return value switch
            {
                CreateImageEditRequestOutputFormat.Png => "png",
                CreateImageEditRequestOutputFormat.Jpeg => "jpeg",
                CreateImageEditRequestOutputFormat.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageEditRequestOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "png" => CreateImageEditRequestOutputFormat.Png,
                "jpeg" => CreateImageEditRequestOutputFormat.Jpeg,
                "webp" => CreateImageEditRequestOutputFormat.Webp,
                _ => null,
            };
        }
    }
}
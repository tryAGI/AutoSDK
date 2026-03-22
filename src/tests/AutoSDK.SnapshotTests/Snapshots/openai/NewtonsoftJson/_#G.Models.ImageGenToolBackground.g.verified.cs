//HintName: G.Models.ImageGenToolBackground.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Background type for the generated image. One of `transparent`, <br/>
    /// `opaque`, or `auto`. Default: `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageGenToolBackground
    {
        /// <summary>
        /// `auto`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// `auto`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opaque")]
        Opaque,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transparent")]
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
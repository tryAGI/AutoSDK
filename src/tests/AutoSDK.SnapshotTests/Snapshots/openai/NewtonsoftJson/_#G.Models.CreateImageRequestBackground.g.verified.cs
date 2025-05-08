//HintName: G.Models.CreateImageRequestBackground.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Allows to set transparency for the background of the generated image(s). <br/>
    /// This parameter is only supported for `gpt-image-1`. Must be one of <br/>
    /// `transparent`, `opaque` or `auto` (default value). When `auto` is used, the <br/>
    /// model will automatically determine the best background for the image.<br/>
    /// If `transparent`, the output format needs to support transparency, so it <br/>
    /// should be set to either `png` (default value) or `webp`.<br/>
    /// Default Value: auto<br/>
    /// Example: transparent
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateImageRequestBackground
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="transparent")]
        Transparent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opaque")]
        Opaque,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestBackground value)
        {
            return value switch
            {
                CreateImageRequestBackground.Transparent => "transparent",
                CreateImageRequestBackground.Opaque => "opaque",
                CreateImageRequestBackground.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestBackground? ToEnum(string value)
        {
            return value switch
            {
                "transparent" => CreateImageRequestBackground.Transparent,
                "opaque" => CreateImageRequestBackground.Opaque,
                "auto" => CreateImageRequestBackground.Auto,
                _ => null,
            };
        }
    }
}
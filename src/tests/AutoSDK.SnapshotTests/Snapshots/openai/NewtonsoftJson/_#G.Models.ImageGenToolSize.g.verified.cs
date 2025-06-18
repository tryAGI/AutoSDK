//HintName: G.Models.ImageGenToolSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The size of the generated image. One of `1024x1024`, `1024x1536`, <br/>
    /// `1536x1024`, or `auto`. Default: `auto`.<br/>
    /// Default Value: auto
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageGenToolSize
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1024")]
        x1024x1024,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1024x1536")]
        x1024x1536,
        /// <summary>
        /// `auto`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="1536x1024")]
        x1536x1024,
        /// <summary>
        /// `auto`.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenToolSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenToolSize value)
        {
            return value switch
            {
                ImageGenToolSize.x1024x1024 => "1024x1024",
                ImageGenToolSize.x1024x1536 => "1024x1536",
                ImageGenToolSize.x1536x1024 => "1536x1024",
                ImageGenToolSize.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenToolSize? ToEnum(string value)
        {
            return value switch
            {
                "1024x1024" => ImageGenToolSize.x1024x1024,
                "1024x1536" => ImageGenToolSize.x1024x1536,
                "1536x1024" => ImageGenToolSize.x1536x1024,
                "auto" => ImageGenToolSize.Auto,
                _ => null,
            };
        }
    }
}
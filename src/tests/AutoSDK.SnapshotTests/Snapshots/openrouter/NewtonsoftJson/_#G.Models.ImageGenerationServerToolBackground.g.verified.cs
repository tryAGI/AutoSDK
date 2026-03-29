//HintName: G.Models.ImageGenerationServerToolBackground.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageGenerationServerToolBackground
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// 
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
    public static class ImageGenerationServerToolBackgroundExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationServerToolBackground value)
        {
            return value switch
            {
                ImageGenerationServerToolBackground.Auto => "auto",
                ImageGenerationServerToolBackground.Opaque => "opaque",
                ImageGenerationServerToolBackground.Transparent => "transparent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationServerToolBackground? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ImageGenerationServerToolBackground.Auto,
                "opaque" => ImageGenerationServerToolBackground.Opaque,
                "transparent" => ImageGenerationServerToolBackground.Transparent,
                _ => null,
            };
        }
    }
}
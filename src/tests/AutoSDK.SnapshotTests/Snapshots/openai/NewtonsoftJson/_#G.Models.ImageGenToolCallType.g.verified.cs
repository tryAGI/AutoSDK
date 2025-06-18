//HintName: G.Models.ImageGenToolCallType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the image generation call. Always `image_generation_call`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageGenToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_generation_call")]
        ImageGenerationCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenToolCallType value)
        {
            return value switch
            {
                ImageGenToolCallType.ImageGenerationCall => "image_generation_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "image_generation_call" => ImageGenToolCallType.ImageGenerationCall,
                _ => null,
            };
        }
    }
}
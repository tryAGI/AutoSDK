//HintName: G.Models.ImageGenToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the image generation tool. Always `image_generation`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageGenToolType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_generation")]
        ImageGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenToolType value)
        {
            return value switch
            {
                ImageGenToolType.ImageGeneration => "image_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenToolType? ToEnum(string value)
        {
            return value switch
            {
                "image_generation" => ImageGenToolType.ImageGeneration,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.GenerateImageResponseType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: image
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GenerateImageResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_to_image")]
        ImageToImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateImageResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageResponseType value)
        {
            return value switch
            {
                GenerateImageResponseType.Image => "image",
                GenerateImageResponseType.ImageToImage => "image_to_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageResponseType? ToEnum(string value)
        {
            return value switch
            {
                "image" => GenerateImageResponseType.Image,
                "image_to_image" => GenerateImageResponseType.ImageToImage,
                _ => null,
            };
        }
    }
}
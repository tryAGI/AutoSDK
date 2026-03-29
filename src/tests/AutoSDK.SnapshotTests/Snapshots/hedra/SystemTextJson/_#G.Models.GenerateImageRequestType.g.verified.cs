//HintName: G.Models.GenerateImageRequestType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: image
    /// </summary>
    public enum GenerateImageRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        ImageToImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateImageRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateImageRequestType value)
        {
            return value switch
            {
                GenerateImageRequestType.Image => "image",
                GenerateImageRequestType.ImageToImage => "image_to_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateImageRequestType? ToEnum(string value)
        {
            return value switch
            {
                "image" => GenerateImageRequestType.Image,
                "image_to_image" => GenerateImageRequestType.ImageToImage,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.ImageFragmentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of content fragment. Must be `image_url` for image fragments.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageFragmentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image_url")]
        ImageUrl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageFragmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageFragmentType value)
        {
            return value switch
            {
                ImageFragmentType.ImageUrl => "image_url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageFragmentType? ToEnum(string value)
        {
            return value switch
            {
                "image_url" => ImageFragmentType.ImageUrl,
                _ => null,
            };
        }
    }
}
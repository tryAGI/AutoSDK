//HintName: G.Models.ImageAssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset - set to `image` for images.<br/>
    /// Default Value: image
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ImageAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageAssetType value)
        {
            return value switch
            {
                ImageAssetType.Image => "image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageAssetType? ToEnum(string value)
        {
            return value switch
            {
                "image" => ImageAssetType.Image,
                _ => null,
            };
        }
    }
}
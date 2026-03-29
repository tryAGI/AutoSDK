//HintName: G.Models.TextToImageAssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset to generate - set to `text-to-image` for text-to-image.<br/>
    /// Default Value: text-to-image
    /// </summary>
    public enum TextToImageAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        TextToImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextToImageAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextToImageAssetType value)
        {
            return value switch
            {
                TextToImageAssetType.TextToImage => "text-to-image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextToImageAssetType? ToEnum(string value)
        {
            return value switch
            {
                "text-to-image" => TextToImageAssetType.TextToImage,
                _ => null,
            };
        }
    }
}
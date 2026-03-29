//HintName: G.Models.CaptionAssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset - set to `caption` for captions.<br/>
    /// Default Value: caption
    /// </summary>
    public enum CaptionAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        Caption,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionAssetType value)
        {
            return value switch
            {
                CaptionAssetType.Caption => "caption",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionAssetType? ToEnum(string value)
        {
            return value switch
            {
                "caption" => CaptionAssetType.Caption,
                _ => null,
            };
        }
    }
}
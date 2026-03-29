//HintName: G.Models.RichCaptionAssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset - set to `rich-caption` for rich captions.<br/>
    /// Default Value: rich-caption
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RichCaptionAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rich-caption")]
        RichCaption,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichCaptionAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichCaptionAssetType value)
        {
            return value switch
            {
                RichCaptionAssetType.RichCaption => "rich-caption",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichCaptionAssetType? ToEnum(string value)
        {
            return value switch
            {
                "rich-caption" => RichCaptionAssetType.RichCaption,
                _ => null,
            };
        }
    }
}
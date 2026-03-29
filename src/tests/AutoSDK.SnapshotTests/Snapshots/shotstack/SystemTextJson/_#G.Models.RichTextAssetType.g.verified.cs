//HintName: G.Models.RichTextAssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset - set to `rich-text` for rich text.<br/>
    /// Default Value: rich-text
    /// </summary>
    public enum RichTextAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        RichText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichTextAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichTextAssetType value)
        {
            return value switch
            {
                RichTextAssetType.RichText => "rich-text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichTextAssetType? ToEnum(string value)
        {
            return value switch
            {
                "rich-text" => RichTextAssetType.RichText,
                _ => null,
            };
        }
    }
}
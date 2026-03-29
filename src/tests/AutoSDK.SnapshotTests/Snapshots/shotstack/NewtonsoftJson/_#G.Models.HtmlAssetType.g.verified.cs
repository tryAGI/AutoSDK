//HintName: G.Models.HtmlAssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset - set to `html` for HTML.<br/>
    /// Default Value: html
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum HtmlAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="html")]
        Html,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HtmlAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HtmlAssetType value)
        {
            return value switch
            {
                HtmlAssetType.Html => "html",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HtmlAssetType? ToEnum(string value)
        {
            return value switch
            {
                "html" => HtmlAssetType.Html,
                _ => null,
            };
        }
    }
}
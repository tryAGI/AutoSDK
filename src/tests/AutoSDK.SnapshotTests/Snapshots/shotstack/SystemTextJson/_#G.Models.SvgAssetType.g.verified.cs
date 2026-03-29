//HintName: G.Models.SvgAssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The asset type - set to `svg` for SVG shapes.<br/>
    /// Default Value: svg<br/>
    /// Example: svg
    /// </summary>
    public enum SvgAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        Svg,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgAssetType value)
        {
            return value switch
            {
                SvgAssetType.Svg => "svg",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgAssetType? ToEnum(string value)
        {
            return value switch
            {
                "svg" => SvgAssetType.Svg,
                _ => null,
            };
        }
    }
}
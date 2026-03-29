//HintName: G.Models.LumaAssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset - set to `luma` for luma mattes.<br/>
    /// Default Value: luma
    /// </summary>
    public enum LumaAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        Luma,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LumaAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LumaAssetType value)
        {
            return value switch
            {
                LumaAssetType.Luma => "luma",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LumaAssetType? ToEnum(string value)
        {
            return value switch
            {
                "luma" => LumaAssetType.Luma,
                _ => null,
            };
        }
    }
}
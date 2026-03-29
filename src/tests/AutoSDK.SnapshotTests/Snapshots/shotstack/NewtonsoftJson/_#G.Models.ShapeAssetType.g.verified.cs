//HintName: G.Models.ShapeAssetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of asset - set to `shape` for shape.<br/>
    /// Default Value: shape
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ShapeAssetType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="shape")]
        Shape,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShapeAssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShapeAssetType value)
        {
            return value switch
            {
                ShapeAssetType.Shape => "shape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShapeAssetType? ToEnum(string value)
        {
            return value switch
            {
                "shape" => ShapeAssetType.Shape,
                _ => null,
            };
        }
    }
}
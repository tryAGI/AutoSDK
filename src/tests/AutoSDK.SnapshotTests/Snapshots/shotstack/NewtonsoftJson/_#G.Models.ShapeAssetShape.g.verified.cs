//HintName: G.Models.ShapeAssetShape.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shape to display.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ShapeAssetShape
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="circle")]
        Circle,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="line")]
        Line,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rectangle")]
        Rectangle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShapeAssetShapeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShapeAssetShape value)
        {
            return value switch
            {
                ShapeAssetShape.Circle => "circle",
                ShapeAssetShape.Line => "line",
                ShapeAssetShape.Rectangle => "rectangle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShapeAssetShape? ToEnum(string value)
        {
            return value switch
            {
                "circle" => ShapeAssetShape.Circle,
                "line" => ShapeAssetShape.Line,
                "rectangle" => ShapeAssetShape.Rectangle,
                _ => null,
            };
        }
    }
}
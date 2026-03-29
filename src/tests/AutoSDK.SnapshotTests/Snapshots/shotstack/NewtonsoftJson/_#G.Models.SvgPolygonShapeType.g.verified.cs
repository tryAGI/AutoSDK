//HintName: G.Models.SvgPolygonShapeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shape type - set to `polygon`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SvgPolygonShapeType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="polygon")]
        Polygon,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgPolygonShapeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgPolygonShapeType value)
        {
            return value switch
            {
                SvgPolygonShapeType.Polygon => "polygon",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgPolygonShapeType? ToEnum(string value)
        {
            return value switch
            {
                "polygon" => SvgPolygonShapeType.Polygon,
                _ => null,
            };
        }
    }
}
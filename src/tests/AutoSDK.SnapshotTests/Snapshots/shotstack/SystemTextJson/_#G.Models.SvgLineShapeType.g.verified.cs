//HintName: G.Models.SvgLineShapeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shape type - set to `line`.
    /// </summary>
    public enum SvgLineShapeType
    {
        /// <summary>
        /// 
        /// </summary>
        Line,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgLineShapeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgLineShapeType value)
        {
            return value switch
            {
                SvgLineShapeType.Line => "line",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgLineShapeType? ToEnum(string value)
        {
            return value switch
            {
                "line" => SvgLineShapeType.Line,
                _ => null,
            };
        }
    }
}
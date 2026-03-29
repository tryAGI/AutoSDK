//HintName: G.Models.SvgEllipseShapeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shape type - set to `ellipse`.
    /// </summary>
    public enum SvgEllipseShapeType
    {
        /// <summary>
        /// 
        /// </summary>
        Ellipse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgEllipseShapeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgEllipseShapeType value)
        {
            return value switch
            {
                SvgEllipseShapeType.Ellipse => "ellipse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgEllipseShapeType? ToEnum(string value)
        {
            return value switch
            {
                "ellipse" => SvgEllipseShapeType.Ellipse,
                _ => null,
            };
        }
    }
}
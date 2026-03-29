//HintName: G.Models.SvgRectangleShapeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shape type - set to `rectangle`.
    /// </summary>
    public enum SvgRectangleShapeType
    {
        /// <summary>
        /// 
        /// </summary>
        Rectangle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgRectangleShapeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgRectangleShapeType value)
        {
            return value switch
            {
                SvgRectangleShapeType.Rectangle => "rectangle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgRectangleShapeType? ToEnum(string value)
        {
            return value switch
            {
                "rectangle" => SvgRectangleShapeType.Rectangle,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.SvgArrowShapeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shape type - set to `arrow`.
    /// </summary>
    public enum SvgArrowShapeType
    {
        /// <summary>
        /// 
        /// </summary>
        Arrow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgArrowShapeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgArrowShapeType value)
        {
            return value switch
            {
                SvgArrowShapeType.Arrow => "arrow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgArrowShapeType? ToEnum(string value)
        {
            return value switch
            {
                "arrow" => SvgArrowShapeType.Arrow,
                _ => null,
            };
        }
    }
}
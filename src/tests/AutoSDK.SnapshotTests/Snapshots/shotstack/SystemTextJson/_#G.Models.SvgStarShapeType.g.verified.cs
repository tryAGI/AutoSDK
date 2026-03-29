//HintName: G.Models.SvgStarShapeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shape type - set to `star`.
    /// </summary>
    public enum SvgStarShapeType
    {
        /// <summary>
        /// 
        /// </summary>
        Star,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgStarShapeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgStarShapeType value)
        {
            return value switch
            {
                SvgStarShapeType.Star => "star",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgStarShapeType? ToEnum(string value)
        {
            return value switch
            {
                "star" => SvgStarShapeType.Star,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.SvgPathShapeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The shape type - set to `path`.
    /// </summary>
    public enum SvgPathShapeType
    {
        /// <summary>
        /// 
        /// </summary>
        Path,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgPathShapeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgPathShapeType value)
        {
            return value switch
            {
                SvgPathShapeType.Path => "path",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgPathShapeType? ToEnum(string value)
        {
            return value switch
            {
                "path" => SvgPathShapeType.Path,
                _ => null,
            };
        }
    }
}
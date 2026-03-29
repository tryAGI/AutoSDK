//HintName: G.Models.SvgSolidFillType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The fill type - set to `solid` for a single color fill.<br/>
    /// Default Value: solid
    /// </summary>
    public enum SvgSolidFillType
    {
        /// <summary>
        /// 
        /// </summary>
        Solid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgSolidFillTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgSolidFillType value)
        {
            return value switch
            {
                SvgSolidFillType.Solid => "solid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgSolidFillType? ToEnum(string value)
        {
            return value switch
            {
                "solid" => SvgSolidFillType.Solid,
                _ => null,
            };
        }
    }
}
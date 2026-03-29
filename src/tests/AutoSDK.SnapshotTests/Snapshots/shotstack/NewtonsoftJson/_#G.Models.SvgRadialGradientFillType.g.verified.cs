//HintName: G.Models.SvgRadialGradientFillType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The fill type - set to `radial` for a radial gradient fill.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SvgRadialGradientFillType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="radial")]
        Radial,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgRadialGradientFillTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgRadialGradientFillType value)
        {
            return value switch
            {
                SvgRadialGradientFillType.Radial => "radial",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgRadialGradientFillType? ToEnum(string value)
        {
            return value switch
            {
                "radial" => SvgRadialGradientFillType.Radial,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.SvgLinearGradientFillType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The fill type - set to `linear` for a linear gradient fill.
    /// </summary>
    public enum SvgLinearGradientFillType
    {
        /// <summary>
        /// 
        /// </summary>
        Linear,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SvgLinearGradientFillTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SvgLinearGradientFillType value)
        {
            return value switch
            {
                SvgLinearGradientFillType.Linear => "linear",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SvgLinearGradientFillType? ToEnum(string value)
        {
            return value switch
            {
                "linear" => SvgLinearGradientFillType.Linear,
                _ => null,
            };
        }
    }
}
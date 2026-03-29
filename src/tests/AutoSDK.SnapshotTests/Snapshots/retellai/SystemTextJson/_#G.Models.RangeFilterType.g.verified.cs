//HintName: G.Models.RangeFilterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RangeFilterType
    {
        /// <summary>
        /// 
        /// </summary>
        Range,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RangeFilterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RangeFilterType value)
        {
            return value switch
            {
                RangeFilterType.Range => "range",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RangeFilterType? ToEnum(string value)
        {
            return value switch
            {
                "range" => RangeFilterType.Range,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.RangeFilterOp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// bt: between
    /// </summary>
    public enum RangeFilterOp
    {
        /// <summary>
        /// between
        /// </summary>
        Bt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RangeFilterOpExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RangeFilterOp value)
        {
            return value switch
            {
                RangeFilterOp.Bt => "bt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RangeFilterOp? ToEnum(string value)
        {
            return value switch
            {
                "bt" => RangeFilterOp.Bt,
                _ => null,
            };
        }
    }
}
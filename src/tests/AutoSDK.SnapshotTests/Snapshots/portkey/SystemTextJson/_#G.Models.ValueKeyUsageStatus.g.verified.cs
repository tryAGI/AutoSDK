//HintName: G.Models.ValueKeyUsageStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Usage status
    /// </summary>
    public enum ValueKeyUsageStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Exhausted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValueKeyUsageStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValueKeyUsageStatus value)
        {
            return value switch
            {
                ValueKeyUsageStatus.Active => "active",
                ValueKeyUsageStatus.Exhausted => "exhausted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValueKeyUsageStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ValueKeyUsageStatus.Active,
                "exhausted" => ValueKeyUsageStatus.Exhausted,
                _ => null,
            };
        }
    }
}
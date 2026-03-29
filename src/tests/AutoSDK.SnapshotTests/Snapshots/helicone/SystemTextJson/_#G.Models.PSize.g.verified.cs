//HintName: G.Models.PSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PSize
    {
        /// <summary>
        /// 
        /// </summary>
        P50,
        /// <summary>
        /// 
        /// </summary>
        P75,
        /// <summary>
        /// 
        /// </summary>
        P95,
        /// <summary>
        /// 
        /// </summary>
        P99,
        /// <summary>
        /// 
        /// </summary>
        P999,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PSize value)
        {
            return value switch
            {
                PSize.P50 => "p50",
                PSize.P75 => "p75",
                PSize.P95 => "p95",
                PSize.P99 => "p99",
                PSize.P999 => "p99.9",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PSize? ToEnum(string value)
        {
            return value switch
            {
                "p50" => PSize.P50,
                "p75" => PSize.P75,
                "p95" => PSize.P95,
                "p99" => PSize.P99,
                "p99.9" => PSize.P999,
                _ => null,
            };
        }
    }
}
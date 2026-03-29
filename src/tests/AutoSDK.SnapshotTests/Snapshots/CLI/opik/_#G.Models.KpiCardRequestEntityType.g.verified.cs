//HintName: G.Models.KpiCardRequestEntityType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum KpiCardRequestEntityType
    {
        /// <summary>
        /// 
        /// </summary>
        Spans,
        /// <summary>
        /// 
        /// </summary>
        Threads,
        /// <summary>
        /// 
        /// </summary>
        Traces,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class KpiCardRequestEntityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KpiCardRequestEntityType value)
        {
            return value switch
            {
                KpiCardRequestEntityType.Spans => "spans",
                KpiCardRequestEntityType.Threads => "threads",
                KpiCardRequestEntityType.Traces => "traces",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KpiCardRequestEntityType? ToEnum(string value)
        {
            return value switch
            {
                "spans" => KpiCardRequestEntityType.Spans,
                "threads" => KpiCardRequestEntityType.Threads,
                "traces" => KpiCardRequestEntityType.Traces,
                _ => null,
            };
        }
    }
}
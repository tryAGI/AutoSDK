//HintName: G.Models.MetricType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MetricType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="credits")]
        Credits,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minutes_used")]
        MinutesUsed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="request_count")]
        RequestCount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ttfb_avg")]
        TtfbAvg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ttfb_p95")]
        TtfbP95,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fiat_units_spent")]
        FiatUnitsSpent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MetricType value)
        {
            return value switch
            {
                MetricType.Credits => "credits",
                MetricType.MinutesUsed => "minutes_used",
                MetricType.RequestCount => "request_count",
                MetricType.TtfbAvg => "ttfb_avg",
                MetricType.TtfbP95 => "ttfb_p95",
                MetricType.FiatUnitsSpent => "fiat_units_spent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MetricType? ToEnum(string value)
        {
            return value switch
            {
                "credits" => MetricType.Credits,
                "minutes_used" => MetricType.MinutesUsed,
                "request_count" => MetricType.RequestCount,
                "ttfb_avg" => MetricType.TtfbAvg,
                "ttfb_p95" => MetricType.TtfbP95,
                "fiat_units_spent" => MetricType.FiatUnitsSpent,
                _ => null,
            };
        }
    }
}
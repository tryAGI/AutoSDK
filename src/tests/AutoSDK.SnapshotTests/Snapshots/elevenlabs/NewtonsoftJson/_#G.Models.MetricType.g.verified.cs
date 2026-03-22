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
        [global::System.Runtime.Serialization.EnumMember(Value="concurrency")]
        Concurrency,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="concurrency_average")]
        ConcurrencyAverage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="credits")]
        Credits,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fiat_units_spent")]
        FiatUnitsSpent,
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
        [global::System.Runtime.Serialization.EnumMember(Value="tts_characters")]
        TtsCharacters,
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
                MetricType.Concurrency => "concurrency",
                MetricType.ConcurrencyAverage => "concurrency_average",
                MetricType.Credits => "credits",
                MetricType.FiatUnitsSpent => "fiat_units_spent",
                MetricType.MinutesUsed => "minutes_used",
                MetricType.RequestCount => "request_count",
                MetricType.TtfbAvg => "ttfb_avg",
                MetricType.TtfbP95 => "ttfb_p95",
                MetricType.TtsCharacters => "tts_characters",
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
                "concurrency" => MetricType.Concurrency,
                "concurrency_average" => MetricType.ConcurrencyAverage,
                "credits" => MetricType.Credits,
                "fiat_units_spent" => MetricType.FiatUnitsSpent,
                "minutes_used" => MetricType.MinutesUsed,
                "request_count" => MetricType.RequestCount,
                "ttfb_avg" => MetricType.TtfbAvg,
                "ttfb_p95" => MetricType.TtfbP95,
                "tts_characters" => MetricType.TtsCharacters,
                _ => null,
            };
        }
    }
}
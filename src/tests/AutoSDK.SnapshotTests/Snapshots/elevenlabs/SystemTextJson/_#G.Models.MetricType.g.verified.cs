//HintName: G.Models.MetricType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MetricType
    {
        /// <summary>
        /// 
        /// </summary>
        Credits,
        /// <summary>
        /// 
        /// </summary>
        TtsCharacters,
        /// <summary>
        /// 
        /// </summary>
        MinutesUsed,
        /// <summary>
        /// 
        /// </summary>
        RequestCount,
        /// <summary>
        /// 
        /// </summary>
        TtfbAvg,
        /// <summary>
        /// 
        /// </summary>
        TtfbP95,
        /// <summary>
        /// 
        /// </summary>
        FiatUnitsSpent,
        /// <summary>
        /// 
        /// </summary>
        Concurrency,
        /// <summary>
        /// 
        /// </summary>
        ConcurrencyAverage,
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
                MetricType.TtsCharacters => "tts_characters",
                MetricType.MinutesUsed => "minutes_used",
                MetricType.RequestCount => "request_count",
                MetricType.TtfbAvg => "ttfb_avg",
                MetricType.TtfbP95 => "ttfb_p95",
                MetricType.FiatUnitsSpent => "fiat_units_spent",
                MetricType.Concurrency => "concurrency",
                MetricType.ConcurrencyAverage => "concurrency_average",
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
                "tts_characters" => MetricType.TtsCharacters,
                "minutes_used" => MetricType.MinutesUsed,
                "request_count" => MetricType.RequestCount,
                "ttfb_avg" => MetricType.TtfbAvg,
                "ttfb_p95" => MetricType.TtfbP95,
                "fiat_units_spent" => MetricType.FiatUnitsSpent,
                "concurrency" => MetricType.Concurrency,
                "concurrency_average" => MetricType.ConcurrencyAverage,
                _ => null,
            };
        }
    }
}
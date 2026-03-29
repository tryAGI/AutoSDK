//HintName: G.Models.CallMetricSpecMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metric to aggregate.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CallMetricSpecMetric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="call_count")]
        CallCount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error_count")]
        ErrorCount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="latency_ms")]
        LatencyMs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CallMetricSpecMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CallMetricSpecMetric value)
        {
            return value switch
            {
                CallMetricSpecMetric.CallCount => "call_count",
                CallMetricSpecMetric.ErrorCount => "error_count",
                CallMetricSpecMetric.LatencyMs => "latency_ms",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CallMetricSpecMetric? ToEnum(string value)
        {
            return value switch
            {
                "call_count" => CallMetricSpecMetric.CallCount,
                "error_count" => CallMetricSpecMetric.ErrorCount,
                "latency_ms" => CallMetricSpecMetric.LatencyMs,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.SessionMetricsQueryParamsPSize.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SessionMetricsQueryParamsPSize
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="p50")]
        P50,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="p75")]
        P75,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="p95")]
        P95,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="p99")]
        P99,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="p99.9")]
        P999,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionMetricsQueryParamsPSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionMetricsQueryParamsPSize value)
        {
            return value switch
            {
                SessionMetricsQueryParamsPSize.P50 => "p50",
                SessionMetricsQueryParamsPSize.P75 => "p75",
                SessionMetricsQueryParamsPSize.P95 => "p95",
                SessionMetricsQueryParamsPSize.P99 => "p99",
                SessionMetricsQueryParamsPSize.P999 => "p99.9",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionMetricsQueryParamsPSize? ToEnum(string value)
        {
            return value switch
            {
                "p50" => SessionMetricsQueryParamsPSize.P50,
                "p75" => SessionMetricsQueryParamsPSize.P75,
                "p95" => SessionMetricsQueryParamsPSize.P95,
                "p99" => SessionMetricsQueryParamsPSize.P99,
                "p99.9" => SessionMetricsQueryParamsPSize.P999,
                _ => null,
            };
        }
    }
}
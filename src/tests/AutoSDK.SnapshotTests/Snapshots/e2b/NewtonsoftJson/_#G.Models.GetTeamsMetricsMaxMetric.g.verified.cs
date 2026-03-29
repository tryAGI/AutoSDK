//HintName: G.Models.GetTeamsMetricsMaxMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetTeamsMetricsMaxMetric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="concurrent_sandboxes")]
        ConcurrentSandboxes,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sandbox_start_rate")]
        SandboxStartRate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTeamsMetricsMaxMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTeamsMetricsMaxMetric value)
        {
            return value switch
            {
                GetTeamsMetricsMaxMetric.ConcurrentSandboxes => "concurrent_sandboxes",
                GetTeamsMetricsMaxMetric.SandboxStartRate => "sandbox_start_rate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTeamsMetricsMaxMetric? ToEnum(string value)
        {
            return value switch
            {
                "concurrent_sandboxes" => GetTeamsMetricsMaxMetric.ConcurrentSandboxes,
                "sandbox_start_rate" => GetTeamsMetricsMaxMetric.SandboxStartRate,
                _ => null,
            };
        }
    }
}
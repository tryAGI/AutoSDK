//HintName: G.Models.UsageMetricSpecMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metric to aggregate. Token metrics are normalized across providers.
    /// </summary>
    public enum UsageMetricSpecMetric
    {
        /// <summary>
        /// 
        /// </summary>
        InputCost,
        /// <summary>
        /// 
        /// </summary>
        InputTokens,
        /// <summary>
        /// 
        /// </summary>
        OutputCost,
        /// <summary>
        /// 
        /// </summary>
        OutputTokens,
        /// <summary>
        /// 
        /// </summary>
        TotalCost,
        /// <summary>
        /// 
        /// </summary>
        TotalTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageMetricSpecMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageMetricSpecMetric value)
        {
            return value switch
            {
                UsageMetricSpecMetric.InputCost => "input_cost",
                UsageMetricSpecMetric.InputTokens => "input_tokens",
                UsageMetricSpecMetric.OutputCost => "output_cost",
                UsageMetricSpecMetric.OutputTokens => "output_tokens",
                UsageMetricSpecMetric.TotalCost => "total_cost",
                UsageMetricSpecMetric.TotalTokens => "total_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageMetricSpecMetric? ToEnum(string value)
        {
            return value switch
            {
                "input_cost" => UsageMetricSpecMetric.InputCost,
                "input_tokens" => UsageMetricSpecMetric.InputTokens,
                "output_cost" => UsageMetricSpecMetric.OutputCost,
                "output_tokens" => UsageMetricSpecMetric.OutputTokens,
                "total_cost" => UsageMetricSpecMetric.TotalCost,
                "total_tokens" => UsageMetricSpecMetric.TotalTokens,
                _ => null,
            };
        }
    }
}
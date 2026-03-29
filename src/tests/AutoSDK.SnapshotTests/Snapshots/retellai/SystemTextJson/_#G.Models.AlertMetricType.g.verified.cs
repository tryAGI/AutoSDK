//HintName: G.Models.AlertMetricType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertMetricType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiErrorCount,
        /// <summary>
        /// 
        /// </summary>
        CallCount,
        /// <summary>
        /// 
        /// </summary>
        CallSuccessRate,
        /// <summary>
        /// 
        /// </summary>
        ConcurrencyUsed,
        /// <summary>
        /// 
        /// </summary>
        CustomFunctionFailureCount,
        /// <summary>
        /// 
        /// </summary>
        CustomFunctionLatency,
        /// <summary>
        /// 
        /// </summary>
        NegativeSentimentRate,
        /// <summary>
        /// 
        /// </summary>
        QaNotPassedCount,
        /// <summary>
        /// 
        /// </summary>
        TotalCallCost,
        /// <summary>
        /// 
        /// </summary>
        TransferCallFailureCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertMetricType value)
        {
            return value switch
            {
                AlertMetricType.ApiErrorCount => "api_error_count",
                AlertMetricType.CallCount => "call_count",
                AlertMetricType.CallSuccessRate => "call_success_rate",
                AlertMetricType.ConcurrencyUsed => "concurrency_used",
                AlertMetricType.CustomFunctionFailureCount => "custom_function_failure_count",
                AlertMetricType.CustomFunctionLatency => "custom_function_latency",
                AlertMetricType.NegativeSentimentRate => "negative_sentiment_rate",
                AlertMetricType.QaNotPassedCount => "qa_not_passed_count",
                AlertMetricType.TotalCallCost => "total_call_cost",
                AlertMetricType.TransferCallFailureCount => "transfer_call_failure_count",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertMetricType? ToEnum(string value)
        {
            return value switch
            {
                "api_error_count" => AlertMetricType.ApiErrorCount,
                "call_count" => AlertMetricType.CallCount,
                "call_success_rate" => AlertMetricType.CallSuccessRate,
                "concurrency_used" => AlertMetricType.ConcurrencyUsed,
                "custom_function_failure_count" => AlertMetricType.CustomFunctionFailureCount,
                "custom_function_latency" => AlertMetricType.CustomFunctionLatency,
                "negative_sentiment_rate" => AlertMetricType.NegativeSentimentRate,
                "qa_not_passed_count" => AlertMetricType.QaNotPassedCount,
                "total_call_cost" => AlertMetricType.TotalCallCost,
                "transfer_call_failure_count" => AlertMetricType.TransferCallFailureCount,
                _ => null,
            };
        }
    }
}
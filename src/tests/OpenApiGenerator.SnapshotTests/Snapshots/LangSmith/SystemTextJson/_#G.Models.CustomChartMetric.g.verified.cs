//HintName: G.Models.CustomChartMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metrics you can chart.
    /// </summary>
    public enum CustomChartMetric
    {
        /// <summary>
        /// 
        /// </summary>
        RunCount,
        /// <summary>
        /// 
        /// </summary>
        LatencyP50,
        /// <summary>
        /// 
        /// </summary>
        LatencyP99,
        /// <summary>
        /// 
        /// </summary>
        FirstTokenP50,
        /// <summary>
        /// 
        /// </summary>
        FirstTokenP99,
        /// <summary>
        /// 
        /// </summary>
        TotalTokens,
        /// <summary>
        /// 
        /// </summary>
        PromptTokens,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        MedianTokens,
        /// <summary>
        /// 
        /// </summary>
        Feedback,
        /// <summary>
        /// 
        /// </summary>
        FeedbackScoreAvg,
        /// <summary>
        /// 
        /// </summary>
        FeedbackValues,
        /// <summary>
        /// 
        /// </summary>
        TotalCost,
        /// <summary>
        /// 
        /// </summary>
        PromptCost,
        /// <summary>
        /// 
        /// </summary>
        CompletionCost,
        /// <summary>
        /// 
        /// </summary>
        ErrorRate,
        /// <summary>
        /// 
        /// </summary>
        StreamingRate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomChartMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomChartMetric value)
        {
            return value switch
            {
                CustomChartMetric.RunCount => "run_count",
                CustomChartMetric.LatencyP50 => "latency_p50",
                CustomChartMetric.LatencyP99 => "latency_p99",
                CustomChartMetric.FirstTokenP50 => "first_token_p50",
                CustomChartMetric.FirstTokenP99 => "first_token_p99",
                CustomChartMetric.TotalTokens => "total_tokens",
                CustomChartMetric.PromptTokens => "prompt_tokens",
                CustomChartMetric.CompletionTokens => "completion_tokens",
                CustomChartMetric.MedianTokens => "median_tokens",
                CustomChartMetric.Feedback => "feedback",
                CustomChartMetric.FeedbackScoreAvg => "feedback_score_avg",
                CustomChartMetric.FeedbackValues => "feedback_values",
                CustomChartMetric.TotalCost => "total_cost",
                CustomChartMetric.PromptCost => "prompt_cost",
                CustomChartMetric.CompletionCost => "completion_cost",
                CustomChartMetric.ErrorRate => "error_rate",
                CustomChartMetric.StreamingRate => "streaming_rate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomChartMetric? ToEnum(string value)
        {
            return value switch
            {
                "run_count" => CustomChartMetric.RunCount,
                "latency_p50" => CustomChartMetric.LatencyP50,
                "latency_p99" => CustomChartMetric.LatencyP99,
                "first_token_p50" => CustomChartMetric.FirstTokenP50,
                "first_token_p99" => CustomChartMetric.FirstTokenP99,
                "total_tokens" => CustomChartMetric.TotalTokens,
                "prompt_tokens" => CustomChartMetric.PromptTokens,
                "completion_tokens" => CustomChartMetric.CompletionTokens,
                "median_tokens" => CustomChartMetric.MedianTokens,
                "feedback" => CustomChartMetric.Feedback,
                "feedback_score_avg" => CustomChartMetric.FeedbackScoreAvg,
                "feedback_values" => CustomChartMetric.FeedbackValues,
                "total_cost" => CustomChartMetric.TotalCost,
                "prompt_cost" => CustomChartMetric.PromptCost,
                "completion_cost" => CustomChartMetric.CompletionCost,
                "error_rate" => CustomChartMetric.ErrorRate,
                "streaming_rate" => CustomChartMetric.StreamingRate,
                _ => null,
            };
        }
    }
}
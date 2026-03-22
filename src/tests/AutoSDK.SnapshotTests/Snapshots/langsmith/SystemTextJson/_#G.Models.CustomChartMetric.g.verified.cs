//HintName: G.Models.CustomChartMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metrics you can chart. Feedback metrics are not available for organization-scoped charts.
    /// </summary>
    public enum CustomChartMetric
    {
        /// <summary>
        /// 
        /// </summary>
        CompletionCost,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokensP50,
        /// <summary>
        /// 
        /// </summary>
        CompletionTokensP99,
        /// <summary>
        /// 
        /// </summary>
        CostP50,
        /// <summary>
        /// 
        /// </summary>
        CostP99,
        /// <summary>
        /// 
        /// </summary>
        ErrorRate,
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
        FirstTokenP50,
        /// <summary>
        /// 
        /// </summary>
        FirstTokenP99,
        /// <summary>
        /// 
        /// </summary>
        LatencyAvg,
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
        MedianTokens,
        /// <summary>
        /// 
        /// </summary>
        PromptCost,
        /// <summary>
        /// 
        /// </summary>
        PromptTokens,
        /// <summary>
        /// 
        /// </summary>
        PromptTokensP50,
        /// <summary>
        /// 
        /// </summary>
        PromptTokensP99,
        /// <summary>
        /// 
        /// </summary>
        RunCount,
        /// <summary>
        /// 
        /// </summary>
        StreamingRate,
        /// <summary>
        /// 
        /// </summary>
        TokensP99,
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
    public static class CustomChartMetricExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomChartMetric value)
        {
            return value switch
            {
                CustomChartMetric.CompletionCost => "completion_cost",
                CustomChartMetric.CompletionTokens => "completion_tokens",
                CustomChartMetric.CompletionTokensP50 => "completion_tokens_p50",
                CustomChartMetric.CompletionTokensP99 => "completion_tokens_p99",
                CustomChartMetric.CostP50 => "cost_p50",
                CustomChartMetric.CostP99 => "cost_p99",
                CustomChartMetric.ErrorRate => "error_rate",
                CustomChartMetric.Feedback => "feedback",
                CustomChartMetric.FeedbackScoreAvg => "feedback_score_avg",
                CustomChartMetric.FeedbackValues => "feedback_values",
                CustomChartMetric.FirstTokenP50 => "first_token_p50",
                CustomChartMetric.FirstTokenP99 => "first_token_p99",
                CustomChartMetric.LatencyAvg => "latency_avg",
                CustomChartMetric.LatencyP50 => "latency_p50",
                CustomChartMetric.LatencyP99 => "latency_p99",
                CustomChartMetric.MedianTokens => "median_tokens",
                CustomChartMetric.PromptCost => "prompt_cost",
                CustomChartMetric.PromptTokens => "prompt_tokens",
                CustomChartMetric.PromptTokensP50 => "prompt_tokens_p50",
                CustomChartMetric.PromptTokensP99 => "prompt_tokens_p99",
                CustomChartMetric.RunCount => "run_count",
                CustomChartMetric.StreamingRate => "streaming_rate",
                CustomChartMetric.TokensP99 => "tokens_p99",
                CustomChartMetric.TotalCost => "total_cost",
                CustomChartMetric.TotalTokens => "total_tokens",
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
                "completion_cost" => CustomChartMetric.CompletionCost,
                "completion_tokens" => CustomChartMetric.CompletionTokens,
                "completion_tokens_p50" => CustomChartMetric.CompletionTokensP50,
                "completion_tokens_p99" => CustomChartMetric.CompletionTokensP99,
                "cost_p50" => CustomChartMetric.CostP50,
                "cost_p99" => CustomChartMetric.CostP99,
                "error_rate" => CustomChartMetric.ErrorRate,
                "feedback" => CustomChartMetric.Feedback,
                "feedback_score_avg" => CustomChartMetric.FeedbackScoreAvg,
                "feedback_values" => CustomChartMetric.FeedbackValues,
                "first_token_p50" => CustomChartMetric.FirstTokenP50,
                "first_token_p99" => CustomChartMetric.FirstTokenP99,
                "latency_avg" => CustomChartMetric.LatencyAvg,
                "latency_p50" => CustomChartMetric.LatencyP50,
                "latency_p99" => CustomChartMetric.LatencyP99,
                "median_tokens" => CustomChartMetric.MedianTokens,
                "prompt_cost" => CustomChartMetric.PromptCost,
                "prompt_tokens" => CustomChartMetric.PromptTokens,
                "prompt_tokens_p50" => CustomChartMetric.PromptTokensP50,
                "prompt_tokens_p99" => CustomChartMetric.PromptTokensP99,
                "run_count" => CustomChartMetric.RunCount,
                "streaming_rate" => CustomChartMetric.StreamingRate,
                "tokens_p99" => CustomChartMetric.TokensP99,
                "total_cost" => CustomChartMetric.TotalCost,
                "total_tokens" => CustomChartMetric.TotalTokens,
                _ => null,
            };
        }
    }
}
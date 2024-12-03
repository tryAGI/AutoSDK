//HintName: G.Models.CustomChartMetric.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metrics you can chart.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CustomChartMetric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="run_count")]
        RunCount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="latency_p50")]
        LatencyP50,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="latency_p99")]
        LatencyP99,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="first_token_p50")]
        FirstTokenP50,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="first_token_p99")]
        FirstTokenP99,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="total_tokens")]
        TotalTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt_tokens")]
        PromptTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completion_tokens")]
        CompletionTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="median_tokens")]
        MedianTokens,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="feedback")]
        Feedback,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="feedback_score_avg")]
        FeedbackScoreAvg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="feedback_values")]
        FeedbackValues,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="total_cost")]
        TotalCost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt_cost")]
        PromptCost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completion_cost")]
        CompletionCost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error_rate")]
        ErrorRate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="streaming_rate")]
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
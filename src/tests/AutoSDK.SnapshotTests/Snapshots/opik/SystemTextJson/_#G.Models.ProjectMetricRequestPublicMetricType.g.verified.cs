//HintName: G.Models.ProjectMetricRequestPublicMetricType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectMetricRequestPublicMetricType
    {
        /// <summary>
        /// 
        /// </summary>
        Cost,
        /// <summary>
        /// 
        /// </summary>
        Duration,
        /// <summary>
        /// 
        /// </summary>
        FeedbackScores,
        /// <summary>
        /// 
        /// </summary>
        GuardrailsFailedCount,
        /// <summary>
        /// 
        /// </summary>
        SpanCount,
        /// <summary>
        /// 
        /// </summary>
        SpanDuration,
        /// <summary>
        /// 
        /// </summary>
        SpanFeedbackScores,
        /// <summary>
        /// 
        /// </summary>
        SpanTokenUsage,
        /// <summary>
        /// 
        /// </summary>
        ThreadCount,
        /// <summary>
        /// 
        /// </summary>
        ThreadDuration,
        /// <summary>
        /// 
        /// </summary>
        ThreadFeedbackScores,
        /// <summary>
        /// 
        /// </summary>
        TokenUsage,
        /// <summary>
        /// 
        /// </summary>
        TraceCount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectMetricRequestPublicMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectMetricRequestPublicMetricType value)
        {
            return value switch
            {
                ProjectMetricRequestPublicMetricType.Cost => "COST",
                ProjectMetricRequestPublicMetricType.Duration => "DURATION",
                ProjectMetricRequestPublicMetricType.FeedbackScores => "FEEDBACK_SCORES",
                ProjectMetricRequestPublicMetricType.GuardrailsFailedCount => "GUARDRAILS_FAILED_COUNT",
                ProjectMetricRequestPublicMetricType.SpanCount => "SPAN_COUNT",
                ProjectMetricRequestPublicMetricType.SpanDuration => "SPAN_DURATION",
                ProjectMetricRequestPublicMetricType.SpanFeedbackScores => "SPAN_FEEDBACK_SCORES",
                ProjectMetricRequestPublicMetricType.SpanTokenUsage => "SPAN_TOKEN_USAGE",
                ProjectMetricRequestPublicMetricType.ThreadCount => "THREAD_COUNT",
                ProjectMetricRequestPublicMetricType.ThreadDuration => "THREAD_DURATION",
                ProjectMetricRequestPublicMetricType.ThreadFeedbackScores => "THREAD_FEEDBACK_SCORES",
                ProjectMetricRequestPublicMetricType.TokenUsage => "TOKEN_USAGE",
                ProjectMetricRequestPublicMetricType.TraceCount => "TRACE_COUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectMetricRequestPublicMetricType? ToEnum(string value)
        {
            return value switch
            {
                "COST" => ProjectMetricRequestPublicMetricType.Cost,
                "DURATION" => ProjectMetricRequestPublicMetricType.Duration,
                "FEEDBACK_SCORES" => ProjectMetricRequestPublicMetricType.FeedbackScores,
                "GUARDRAILS_FAILED_COUNT" => ProjectMetricRequestPublicMetricType.GuardrailsFailedCount,
                "SPAN_COUNT" => ProjectMetricRequestPublicMetricType.SpanCount,
                "SPAN_DURATION" => ProjectMetricRequestPublicMetricType.SpanDuration,
                "SPAN_FEEDBACK_SCORES" => ProjectMetricRequestPublicMetricType.SpanFeedbackScores,
                "SPAN_TOKEN_USAGE" => ProjectMetricRequestPublicMetricType.SpanTokenUsage,
                "THREAD_COUNT" => ProjectMetricRequestPublicMetricType.ThreadCount,
                "THREAD_DURATION" => ProjectMetricRequestPublicMetricType.ThreadDuration,
                "THREAD_FEEDBACK_SCORES" => ProjectMetricRequestPublicMetricType.ThreadFeedbackScores,
                "TOKEN_USAGE" => ProjectMetricRequestPublicMetricType.TokenUsage,
                "TRACE_COUNT" => ProjectMetricRequestPublicMetricType.TraceCount,
                _ => null,
            };
        }
    }
}
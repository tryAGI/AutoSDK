//HintName: G.Models.ProjectMetricResponsePublicMetricType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProjectMetricResponsePublicMetricType
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
    public static class ProjectMetricResponsePublicMetricTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectMetricResponsePublicMetricType value)
        {
            return value switch
            {
                ProjectMetricResponsePublicMetricType.Cost => "COST",
                ProjectMetricResponsePublicMetricType.Duration => "DURATION",
                ProjectMetricResponsePublicMetricType.FeedbackScores => "FEEDBACK_SCORES",
                ProjectMetricResponsePublicMetricType.GuardrailsFailedCount => "GUARDRAILS_FAILED_COUNT",
                ProjectMetricResponsePublicMetricType.SpanCount => "SPAN_COUNT",
                ProjectMetricResponsePublicMetricType.SpanDuration => "SPAN_DURATION",
                ProjectMetricResponsePublicMetricType.SpanFeedbackScores => "SPAN_FEEDBACK_SCORES",
                ProjectMetricResponsePublicMetricType.SpanTokenUsage => "SPAN_TOKEN_USAGE",
                ProjectMetricResponsePublicMetricType.ThreadCount => "THREAD_COUNT",
                ProjectMetricResponsePublicMetricType.ThreadDuration => "THREAD_DURATION",
                ProjectMetricResponsePublicMetricType.ThreadFeedbackScores => "THREAD_FEEDBACK_SCORES",
                ProjectMetricResponsePublicMetricType.TokenUsage => "TOKEN_USAGE",
                ProjectMetricResponsePublicMetricType.TraceCount => "TRACE_COUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectMetricResponsePublicMetricType? ToEnum(string value)
        {
            return value switch
            {
                "COST" => ProjectMetricResponsePublicMetricType.Cost,
                "DURATION" => ProjectMetricResponsePublicMetricType.Duration,
                "FEEDBACK_SCORES" => ProjectMetricResponsePublicMetricType.FeedbackScores,
                "GUARDRAILS_FAILED_COUNT" => ProjectMetricResponsePublicMetricType.GuardrailsFailedCount,
                "SPAN_COUNT" => ProjectMetricResponsePublicMetricType.SpanCount,
                "SPAN_DURATION" => ProjectMetricResponsePublicMetricType.SpanDuration,
                "SPAN_FEEDBACK_SCORES" => ProjectMetricResponsePublicMetricType.SpanFeedbackScores,
                "SPAN_TOKEN_USAGE" => ProjectMetricResponsePublicMetricType.SpanTokenUsage,
                "THREAD_COUNT" => ProjectMetricResponsePublicMetricType.ThreadCount,
                "THREAD_DURATION" => ProjectMetricResponsePublicMetricType.ThreadDuration,
                "THREAD_FEEDBACK_SCORES" => ProjectMetricResponsePublicMetricType.ThreadFeedbackScores,
                "TOKEN_USAGE" => ProjectMetricResponsePublicMetricType.TokenUsage,
                "TRACE_COUNT" => ProjectMetricResponsePublicMetricType.TraceCount,
                _ => null,
            };
        }
    }
}
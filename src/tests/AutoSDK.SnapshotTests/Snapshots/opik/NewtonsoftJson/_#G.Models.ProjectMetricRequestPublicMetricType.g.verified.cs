//HintName: G.Models.ProjectMetricRequestPublicMetricType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectMetricRequestPublicMetricType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COST")]
        Cost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DURATION")]
        Duration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FEEDBACK_SCORES")]
        FeedbackScores,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GUARDRAILS_FAILED_COUNT")]
        GuardrailsFailedCount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SPAN_COUNT")]
        SpanCount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SPAN_DURATION")]
        SpanDuration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SPAN_FEEDBACK_SCORES")]
        SpanFeedbackScores,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SPAN_TOKEN_USAGE")]
        SpanTokenUsage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="THREAD_COUNT")]
        ThreadCount,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="THREAD_DURATION")]
        ThreadDuration,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="THREAD_FEEDBACK_SCORES")]
        ThreadFeedbackScores,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TOKEN_USAGE")]
        TokenUsage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TRACE_COUNT")]
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
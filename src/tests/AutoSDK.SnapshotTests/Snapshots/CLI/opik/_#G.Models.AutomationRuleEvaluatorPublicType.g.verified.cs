//HintName: G.Models.AutomationRuleEvaluatorPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutomationRuleEvaluatorPublicType
    {
        /// <summary>
        /// 
        /// </summary>
        LlmAsJudge,
        /// <summary>
        /// 
        /// </summary>
        SpanLlmAsJudge,
        /// <summary>
        /// 
        /// </summary>
        SpanUserDefinedMetricPython,
        /// <summary>
        /// 
        /// </summary>
        TraceThreadLlmAsJudge,
        /// <summary>
        /// 
        /// </summary>
        TraceThreadUserDefinedMetricPython,
        /// <summary>
        /// 
        /// </summary>
        UserDefinedMetricPython,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationRuleEvaluatorPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorPublicType value)
        {
            return value switch
            {
                AutomationRuleEvaluatorPublicType.LlmAsJudge => "llm_as_judge",
                AutomationRuleEvaluatorPublicType.SpanLlmAsJudge => "span_llm_as_judge",
                AutomationRuleEvaluatorPublicType.SpanUserDefinedMetricPython => "span_user_defined_metric_python",
                AutomationRuleEvaluatorPublicType.TraceThreadLlmAsJudge => "trace_thread_llm_as_judge",
                AutomationRuleEvaluatorPublicType.TraceThreadUserDefinedMetricPython => "trace_thread_user_defined_metric_python",
                AutomationRuleEvaluatorPublicType.UserDefinedMetricPython => "user_defined_metric_python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorPublicType? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => AutomationRuleEvaluatorPublicType.LlmAsJudge,
                "span_llm_as_judge" => AutomationRuleEvaluatorPublicType.SpanLlmAsJudge,
                "span_user_defined_metric_python" => AutomationRuleEvaluatorPublicType.SpanUserDefinedMetricPython,
                "trace_thread_llm_as_judge" => AutomationRuleEvaluatorPublicType.TraceThreadLlmAsJudge,
                "trace_thread_user_defined_metric_python" => AutomationRuleEvaluatorPublicType.TraceThreadUserDefinedMetricPython,
                "user_defined_metric_python" => AutomationRuleEvaluatorPublicType.UserDefinedMetricPython,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.AutomationRuleEvaluatorWriteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutomationRuleEvaluatorWriteType
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
    public static class AutomationRuleEvaluatorWriteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorWriteType value)
        {
            return value switch
            {
                AutomationRuleEvaluatorWriteType.LlmAsJudge => "llm_as_judge",
                AutomationRuleEvaluatorWriteType.SpanLlmAsJudge => "span_llm_as_judge",
                AutomationRuleEvaluatorWriteType.SpanUserDefinedMetricPython => "span_user_defined_metric_python",
                AutomationRuleEvaluatorWriteType.TraceThreadLlmAsJudge => "trace_thread_llm_as_judge",
                AutomationRuleEvaluatorWriteType.TraceThreadUserDefinedMetricPython => "trace_thread_user_defined_metric_python",
                AutomationRuleEvaluatorWriteType.UserDefinedMetricPython => "user_defined_metric_python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorWriteType? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => AutomationRuleEvaluatorWriteType.LlmAsJudge,
                "span_llm_as_judge" => AutomationRuleEvaluatorWriteType.SpanLlmAsJudge,
                "span_user_defined_metric_python" => AutomationRuleEvaluatorWriteType.SpanUserDefinedMetricPython,
                "trace_thread_llm_as_judge" => AutomationRuleEvaluatorWriteType.TraceThreadLlmAsJudge,
                "trace_thread_user_defined_metric_python" => AutomationRuleEvaluatorWriteType.TraceThreadUserDefinedMetricPython,
                "user_defined_metric_python" => AutomationRuleEvaluatorWriteType.UserDefinedMetricPython,
                _ => null,
            };
        }
    }
}
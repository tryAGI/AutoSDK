//HintName: G.Models.AutomationRuleEvaluatorObjectObjectPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutomationRuleEvaluatorObjectObjectPublicType
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
    public static class AutomationRuleEvaluatorObjectObjectPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorObjectObjectPublicType value)
        {
            return value switch
            {
                AutomationRuleEvaluatorObjectObjectPublicType.LlmAsJudge => "llm_as_judge",
                AutomationRuleEvaluatorObjectObjectPublicType.SpanLlmAsJudge => "span_llm_as_judge",
                AutomationRuleEvaluatorObjectObjectPublicType.SpanUserDefinedMetricPython => "span_user_defined_metric_python",
                AutomationRuleEvaluatorObjectObjectPublicType.TraceThreadLlmAsJudge => "trace_thread_llm_as_judge",
                AutomationRuleEvaluatorObjectObjectPublicType.TraceThreadUserDefinedMetricPython => "trace_thread_user_defined_metric_python",
                AutomationRuleEvaluatorObjectObjectPublicType.UserDefinedMetricPython => "user_defined_metric_python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorObjectObjectPublicType? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => AutomationRuleEvaluatorObjectObjectPublicType.LlmAsJudge,
                "span_llm_as_judge" => AutomationRuleEvaluatorObjectObjectPublicType.SpanLlmAsJudge,
                "span_user_defined_metric_python" => AutomationRuleEvaluatorObjectObjectPublicType.SpanUserDefinedMetricPython,
                "trace_thread_llm_as_judge" => AutomationRuleEvaluatorObjectObjectPublicType.TraceThreadLlmAsJudge,
                "trace_thread_user_defined_metric_python" => AutomationRuleEvaluatorObjectObjectPublicType.TraceThreadUserDefinedMetricPython,
                "user_defined_metric_python" => AutomationRuleEvaluatorObjectObjectPublicType.UserDefinedMetricPython,
                _ => null,
            };
        }
    }
}
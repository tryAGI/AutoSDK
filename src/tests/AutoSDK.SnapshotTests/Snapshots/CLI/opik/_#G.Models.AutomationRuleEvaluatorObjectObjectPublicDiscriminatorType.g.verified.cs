//HintName: G.Models.AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType
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
    public static class AutomationRuleEvaluatorObjectObjectPublicDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType value)
        {
            return value switch
            {
                AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType.LlmAsJudge => "llm_as_judge",
                AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType.SpanLlmAsJudge => "span_llm_as_judge",
                AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType.SpanUserDefinedMetricPython => "span_user_defined_metric_python",
                AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType.TraceThreadLlmAsJudge => "trace_thread_llm_as_judge",
                AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType.TraceThreadUserDefinedMetricPython => "trace_thread_user_defined_metric_python",
                AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType.UserDefinedMetricPython => "user_defined_metric_python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType.LlmAsJudge,
                "span_llm_as_judge" => AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType.SpanLlmAsJudge,
                "span_user_defined_metric_python" => AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType.SpanUserDefinedMetricPython,
                "trace_thread_llm_as_judge" => AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType.TraceThreadLlmAsJudge,
                "trace_thread_user_defined_metric_python" => AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType.TraceThreadUserDefinedMetricPython,
                "user_defined_metric_python" => AutomationRuleEvaluatorObjectObjectPublicDiscriminatorType.UserDefinedMetricPython,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.AutomationRuleEvaluatorDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AutomationRuleEvaluatorDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm_as_judge")]
        LlmAsJudge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="span_llm_as_judge")]
        SpanLlmAsJudge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="span_user_defined_metric_python")]
        SpanUserDefinedMetricPython,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace_thread_llm_as_judge")]
        TraceThreadLlmAsJudge,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace_thread_user_defined_metric_python")]
        TraceThreadUserDefinedMetricPython,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_defined_metric_python")]
        UserDefinedMetricPython,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AutomationRuleEvaluatorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorDiscriminatorType value)
        {
            return value switch
            {
                AutomationRuleEvaluatorDiscriminatorType.LlmAsJudge => "llm_as_judge",
                AutomationRuleEvaluatorDiscriminatorType.SpanLlmAsJudge => "span_llm_as_judge",
                AutomationRuleEvaluatorDiscriminatorType.SpanUserDefinedMetricPython => "span_user_defined_metric_python",
                AutomationRuleEvaluatorDiscriminatorType.TraceThreadLlmAsJudge => "trace_thread_llm_as_judge",
                AutomationRuleEvaluatorDiscriminatorType.TraceThreadUserDefinedMetricPython => "trace_thread_user_defined_metric_python",
                AutomationRuleEvaluatorDiscriminatorType.UserDefinedMetricPython => "user_defined_metric_python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => AutomationRuleEvaluatorDiscriminatorType.LlmAsJudge,
                "span_llm_as_judge" => AutomationRuleEvaluatorDiscriminatorType.SpanLlmAsJudge,
                "span_user_defined_metric_python" => AutomationRuleEvaluatorDiscriminatorType.SpanUserDefinedMetricPython,
                "trace_thread_llm_as_judge" => AutomationRuleEvaluatorDiscriminatorType.TraceThreadLlmAsJudge,
                "trace_thread_user_defined_metric_python" => AutomationRuleEvaluatorDiscriminatorType.TraceThreadUserDefinedMetricPython,
                "user_defined_metric_python" => AutomationRuleEvaluatorDiscriminatorType.UserDefinedMetricPython,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.AutomationRuleEvaluatorUpdateDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AutomationRuleEvaluatorUpdateDiscriminatorType
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
    public static class AutomationRuleEvaluatorUpdateDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorUpdateDiscriminatorType value)
        {
            return value switch
            {
                AutomationRuleEvaluatorUpdateDiscriminatorType.LlmAsJudge => "llm_as_judge",
                AutomationRuleEvaluatorUpdateDiscriminatorType.SpanLlmAsJudge => "span_llm_as_judge",
                AutomationRuleEvaluatorUpdateDiscriminatorType.SpanUserDefinedMetricPython => "span_user_defined_metric_python",
                AutomationRuleEvaluatorUpdateDiscriminatorType.TraceThreadLlmAsJudge => "trace_thread_llm_as_judge",
                AutomationRuleEvaluatorUpdateDiscriminatorType.TraceThreadUserDefinedMetricPython => "trace_thread_user_defined_metric_python",
                AutomationRuleEvaluatorUpdateDiscriminatorType.UserDefinedMetricPython => "user_defined_metric_python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorUpdateDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => AutomationRuleEvaluatorUpdateDiscriminatorType.LlmAsJudge,
                "span_llm_as_judge" => AutomationRuleEvaluatorUpdateDiscriminatorType.SpanLlmAsJudge,
                "span_user_defined_metric_python" => AutomationRuleEvaluatorUpdateDiscriminatorType.SpanUserDefinedMetricPython,
                "trace_thread_llm_as_judge" => AutomationRuleEvaluatorUpdateDiscriminatorType.TraceThreadLlmAsJudge,
                "trace_thread_user_defined_metric_python" => AutomationRuleEvaluatorUpdateDiscriminatorType.TraceThreadUserDefinedMetricPython,
                "user_defined_metric_python" => AutomationRuleEvaluatorUpdateDiscriminatorType.UserDefinedMetricPython,
                _ => null,
            };
        }
    }
}
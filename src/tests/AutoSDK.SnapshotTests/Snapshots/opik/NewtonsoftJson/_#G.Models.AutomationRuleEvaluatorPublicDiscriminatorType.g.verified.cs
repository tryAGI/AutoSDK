//HintName: G.Models.AutomationRuleEvaluatorPublicDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AutomationRuleEvaluatorPublicDiscriminatorType
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
    public static class AutomationRuleEvaluatorPublicDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorPublicDiscriminatorType value)
        {
            return value switch
            {
                AutomationRuleEvaluatorPublicDiscriminatorType.LlmAsJudge => "llm_as_judge",
                AutomationRuleEvaluatorPublicDiscriminatorType.SpanLlmAsJudge => "span_llm_as_judge",
                AutomationRuleEvaluatorPublicDiscriminatorType.SpanUserDefinedMetricPython => "span_user_defined_metric_python",
                AutomationRuleEvaluatorPublicDiscriminatorType.TraceThreadLlmAsJudge => "trace_thread_llm_as_judge",
                AutomationRuleEvaluatorPublicDiscriminatorType.TraceThreadUserDefinedMetricPython => "trace_thread_user_defined_metric_python",
                AutomationRuleEvaluatorPublicDiscriminatorType.UserDefinedMetricPython => "user_defined_metric_python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorPublicDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => AutomationRuleEvaluatorPublicDiscriminatorType.LlmAsJudge,
                "span_llm_as_judge" => AutomationRuleEvaluatorPublicDiscriminatorType.SpanLlmAsJudge,
                "span_user_defined_metric_python" => AutomationRuleEvaluatorPublicDiscriminatorType.SpanUserDefinedMetricPython,
                "trace_thread_llm_as_judge" => AutomationRuleEvaluatorPublicDiscriminatorType.TraceThreadLlmAsJudge,
                "trace_thread_user_defined_metric_python" => AutomationRuleEvaluatorPublicDiscriminatorType.TraceThreadUserDefinedMetricPython,
                "user_defined_metric_python" => AutomationRuleEvaluatorPublicDiscriminatorType.UserDefinedMetricPython,
                _ => null,
            };
        }
    }
}
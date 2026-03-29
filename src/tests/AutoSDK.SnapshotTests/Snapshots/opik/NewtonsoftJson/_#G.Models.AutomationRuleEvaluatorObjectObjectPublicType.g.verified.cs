//HintName: G.Models.AutomationRuleEvaluatorObjectObjectPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AutomationRuleEvaluatorObjectObjectPublicType
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
//HintName: G.Models.AutomationRuleEvaluatorUpdateType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AutomationRuleEvaluatorUpdateType
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
    public static class AutomationRuleEvaluatorUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AutomationRuleEvaluatorUpdateType value)
        {
            return value switch
            {
                AutomationRuleEvaluatorUpdateType.LlmAsJudge => "llm_as_judge",
                AutomationRuleEvaluatorUpdateType.SpanLlmAsJudge => "span_llm_as_judge",
                AutomationRuleEvaluatorUpdateType.SpanUserDefinedMetricPython => "span_user_defined_metric_python",
                AutomationRuleEvaluatorUpdateType.TraceThreadLlmAsJudge => "trace_thread_llm_as_judge",
                AutomationRuleEvaluatorUpdateType.TraceThreadUserDefinedMetricPython => "trace_thread_user_defined_metric_python",
                AutomationRuleEvaluatorUpdateType.UserDefinedMetricPython => "user_defined_metric_python",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AutomationRuleEvaluatorUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "llm_as_judge" => AutomationRuleEvaluatorUpdateType.LlmAsJudge,
                "span_llm_as_judge" => AutomationRuleEvaluatorUpdateType.SpanLlmAsJudge,
                "span_user_defined_metric_python" => AutomationRuleEvaluatorUpdateType.SpanUserDefinedMetricPython,
                "trace_thread_llm_as_judge" => AutomationRuleEvaluatorUpdateType.TraceThreadLlmAsJudge,
                "trace_thread_user_defined_metric_python" => AutomationRuleEvaluatorUpdateType.TraceThreadUserDefinedMetricPython,
                "user_defined_metric_python" => AutomationRuleEvaluatorUpdateType.UserDefinedMetricPython,
                _ => null,
            };
        }
    }
}
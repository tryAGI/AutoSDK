//HintName: G.Models.AlertTriggerEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertTriggerEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiment:finished")]
        Experiment_finished,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt:committed")]
        Prompt_committed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt:created")]
        Prompt_created,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt:deleted")]
        Prompt_deleted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace:cost")]
        Trace_cost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace:errors")]
        Trace_errors,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace:feedback_score")]
        Trace_feedbackScore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace:guardrails_triggered")]
        Trace_guardrailsTriggered,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace:latency")]
        Trace_latency,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="trace_thread:feedback_score")]
        TraceThread_feedbackScore,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertTriggerEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertTriggerEventType value)
        {
            return value switch
            {
                AlertTriggerEventType.Experiment_finished => "experiment:finished",
                AlertTriggerEventType.Prompt_committed => "prompt:committed",
                AlertTriggerEventType.Prompt_created => "prompt:created",
                AlertTriggerEventType.Prompt_deleted => "prompt:deleted",
                AlertTriggerEventType.Trace_cost => "trace:cost",
                AlertTriggerEventType.Trace_errors => "trace:errors",
                AlertTriggerEventType.Trace_feedbackScore => "trace:feedback_score",
                AlertTriggerEventType.Trace_guardrailsTriggered => "trace:guardrails_triggered",
                AlertTriggerEventType.Trace_latency => "trace:latency",
                AlertTriggerEventType.TraceThread_feedbackScore => "trace_thread:feedback_score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertTriggerEventType? ToEnum(string value)
        {
            return value switch
            {
                "experiment:finished" => AlertTriggerEventType.Experiment_finished,
                "prompt:committed" => AlertTriggerEventType.Prompt_committed,
                "prompt:created" => AlertTriggerEventType.Prompt_created,
                "prompt:deleted" => AlertTriggerEventType.Prompt_deleted,
                "trace:cost" => AlertTriggerEventType.Trace_cost,
                "trace:errors" => AlertTriggerEventType.Trace_errors,
                "trace:feedback_score" => AlertTriggerEventType.Trace_feedbackScore,
                "trace:guardrails_triggered" => AlertTriggerEventType.Trace_guardrailsTriggered,
                "trace:latency" => AlertTriggerEventType.Trace_latency,
                "trace_thread:feedback_score" => AlertTriggerEventType.TraceThread_feedbackScore,
                _ => null,
            };
        }
    }
}
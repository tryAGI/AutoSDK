//HintName: G.Models.AlertTriggerWriteEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertTriggerWriteEventType
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
    public static class AlertTriggerWriteEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertTriggerWriteEventType value)
        {
            return value switch
            {
                AlertTriggerWriteEventType.Experiment_finished => "experiment:finished",
                AlertTriggerWriteEventType.Prompt_committed => "prompt:committed",
                AlertTriggerWriteEventType.Prompt_created => "prompt:created",
                AlertTriggerWriteEventType.Prompt_deleted => "prompt:deleted",
                AlertTriggerWriteEventType.Trace_cost => "trace:cost",
                AlertTriggerWriteEventType.Trace_errors => "trace:errors",
                AlertTriggerWriteEventType.Trace_feedbackScore => "trace:feedback_score",
                AlertTriggerWriteEventType.Trace_guardrailsTriggered => "trace:guardrails_triggered",
                AlertTriggerWriteEventType.Trace_latency => "trace:latency",
                AlertTriggerWriteEventType.TraceThread_feedbackScore => "trace_thread:feedback_score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertTriggerWriteEventType? ToEnum(string value)
        {
            return value switch
            {
                "experiment:finished" => AlertTriggerWriteEventType.Experiment_finished,
                "prompt:committed" => AlertTriggerWriteEventType.Prompt_committed,
                "prompt:created" => AlertTriggerWriteEventType.Prompt_created,
                "prompt:deleted" => AlertTriggerWriteEventType.Prompt_deleted,
                "trace:cost" => AlertTriggerWriteEventType.Trace_cost,
                "trace:errors" => AlertTriggerWriteEventType.Trace_errors,
                "trace:feedback_score" => AlertTriggerWriteEventType.Trace_feedbackScore,
                "trace:guardrails_triggered" => AlertTriggerWriteEventType.Trace_guardrailsTriggered,
                "trace:latency" => AlertTriggerWriteEventType.Trace_latency,
                "trace_thread:feedback_score" => AlertTriggerWriteEventType.TraceThread_feedbackScore,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.AlertTriggerPublicEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertTriggerPublicEventType
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
    public static class AlertTriggerPublicEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertTriggerPublicEventType value)
        {
            return value switch
            {
                AlertTriggerPublicEventType.Experiment_finished => "experiment:finished",
                AlertTriggerPublicEventType.Prompt_committed => "prompt:committed",
                AlertTriggerPublicEventType.Prompt_created => "prompt:created",
                AlertTriggerPublicEventType.Prompt_deleted => "prompt:deleted",
                AlertTriggerPublicEventType.Trace_cost => "trace:cost",
                AlertTriggerPublicEventType.Trace_errors => "trace:errors",
                AlertTriggerPublicEventType.Trace_feedbackScore => "trace:feedback_score",
                AlertTriggerPublicEventType.Trace_guardrailsTriggered => "trace:guardrails_triggered",
                AlertTriggerPublicEventType.Trace_latency => "trace:latency",
                AlertTriggerPublicEventType.TraceThread_feedbackScore => "trace_thread:feedback_score",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertTriggerPublicEventType? ToEnum(string value)
        {
            return value switch
            {
                "experiment:finished" => AlertTriggerPublicEventType.Experiment_finished,
                "prompt:committed" => AlertTriggerPublicEventType.Prompt_committed,
                "prompt:created" => AlertTriggerPublicEventType.Prompt_created,
                "prompt:deleted" => AlertTriggerPublicEventType.Prompt_deleted,
                "trace:cost" => AlertTriggerPublicEventType.Trace_cost,
                "trace:errors" => AlertTriggerPublicEventType.Trace_errors,
                "trace:feedback_score" => AlertTriggerPublicEventType.Trace_feedbackScore,
                "trace:guardrails_triggered" => AlertTriggerPublicEventType.Trace_guardrailsTriggered,
                "trace:latency" => AlertTriggerPublicEventType.Trace_latency,
                "trace_thread:feedback_score" => AlertTriggerPublicEventType.TraceThread_feedbackScore,
                _ => null,
            };
        }
    }
}
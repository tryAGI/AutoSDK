//HintName: G.Models.AlertTriggerConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AlertTriggerConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        Scope_project,
        /// <summary>
        /// 
        /// </summary>
        Threshold_cost,
        /// <summary>
        /// 
        /// </summary>
        Threshold_errors,
        /// <summary>
        /// 
        /// </summary>
        Threshold_feedbackScore,
        /// <summary>
        /// 
        /// </summary>
        Threshold_latency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AlertTriggerConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertTriggerConfigType value)
        {
            return value switch
            {
                AlertTriggerConfigType.Scope_project => "scope:project",
                AlertTriggerConfigType.Threshold_cost => "threshold:cost",
                AlertTriggerConfigType.Threshold_errors => "threshold:errors",
                AlertTriggerConfigType.Threshold_feedbackScore => "threshold:feedback_score",
                AlertTriggerConfigType.Threshold_latency => "threshold:latency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertTriggerConfigType? ToEnum(string value)
        {
            return value switch
            {
                "scope:project" => AlertTriggerConfigType.Scope_project,
                "threshold:cost" => AlertTriggerConfigType.Threshold_cost,
                "threshold:errors" => AlertTriggerConfigType.Threshold_errors,
                "threshold:feedback_score" => AlertTriggerConfigType.Threshold_feedbackScore,
                "threshold:latency" => AlertTriggerConfigType.Threshold_latency,
                _ => null,
            };
        }
    }
}
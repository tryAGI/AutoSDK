//HintName: G.Models.AlertTriggerConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertTriggerConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scope:project")]
        Scope_project,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="threshold:cost")]
        Threshold_cost,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="threshold:errors")]
        Threshold_errors,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="threshold:feedback_score")]
        Threshold_feedbackScore,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="threshold:latency")]
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
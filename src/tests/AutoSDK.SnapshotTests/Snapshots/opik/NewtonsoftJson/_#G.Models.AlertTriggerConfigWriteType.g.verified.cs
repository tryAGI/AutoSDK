//HintName: G.Models.AlertTriggerConfigWriteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertTriggerConfigWriteType
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
    public static class AlertTriggerConfigWriteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertTriggerConfigWriteType value)
        {
            return value switch
            {
                AlertTriggerConfigWriteType.Scope_project => "scope:project",
                AlertTriggerConfigWriteType.Threshold_cost => "threshold:cost",
                AlertTriggerConfigWriteType.Threshold_errors => "threshold:errors",
                AlertTriggerConfigWriteType.Threshold_feedbackScore => "threshold:feedback_score",
                AlertTriggerConfigWriteType.Threshold_latency => "threshold:latency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertTriggerConfigWriteType? ToEnum(string value)
        {
            return value switch
            {
                "scope:project" => AlertTriggerConfigWriteType.Scope_project,
                "threshold:cost" => AlertTriggerConfigWriteType.Threshold_cost,
                "threshold:errors" => AlertTriggerConfigWriteType.Threshold_errors,
                "threshold:feedback_score" => AlertTriggerConfigWriteType.Threshold_feedbackScore,
                "threshold:latency" => AlertTriggerConfigWriteType.Threshold_latency,
                _ => null,
            };
        }
    }
}
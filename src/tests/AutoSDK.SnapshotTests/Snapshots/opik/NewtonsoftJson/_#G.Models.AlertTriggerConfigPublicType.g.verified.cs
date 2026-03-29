//HintName: G.Models.AlertTriggerConfigPublicType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AlertTriggerConfigPublicType
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
    public static class AlertTriggerConfigPublicTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AlertTriggerConfigPublicType value)
        {
            return value switch
            {
                AlertTriggerConfigPublicType.Scope_project => "scope:project",
                AlertTriggerConfigPublicType.Threshold_cost => "threshold:cost",
                AlertTriggerConfigPublicType.Threshold_errors => "threshold:errors",
                AlertTriggerConfigPublicType.Threshold_feedbackScore => "threshold:feedback_score",
                AlertTriggerConfigPublicType.Threshold_latency => "threshold:latency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AlertTriggerConfigPublicType? ToEnum(string value)
        {
            return value switch
            {
                "scope:project" => AlertTriggerConfigPublicType.Scope_project,
                "threshold:cost" => AlertTriggerConfigPublicType.Threshold_cost,
                "threshold:errors" => AlertTriggerConfigPublicType.Threshold_errors,
                "threshold:feedback_score" => AlertTriggerConfigPublicType.Threshold_feedbackScore,
                "threshold:latency" => AlertTriggerConfigPublicType.Threshold_latency,
                _ => null,
            };
        }
    }
}
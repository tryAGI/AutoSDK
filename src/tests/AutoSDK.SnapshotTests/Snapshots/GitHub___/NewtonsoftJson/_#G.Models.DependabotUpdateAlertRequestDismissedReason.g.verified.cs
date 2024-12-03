//HintName: G.Models.DependabotUpdateAlertRequestDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// **Required when `state` is `dismissed`.** A reason for dismissing the alert.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotUpdateAlertRequestDismissedReason
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fix_started")]
        FixStarted,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="inaccurate")]
        Inaccurate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="no_bandwidth")]
        NoBandwidth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_used")]
        NotUsed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tolerable_risk")]
        TolerableRisk,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DependabotUpdateAlertRequestDismissedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotUpdateAlertRequestDismissedReason value)
        {
            return value switch
            {
                DependabotUpdateAlertRequestDismissedReason.FixStarted => "fix_started",
                DependabotUpdateAlertRequestDismissedReason.Inaccurate => "inaccurate",
                DependabotUpdateAlertRequestDismissedReason.NoBandwidth => "no_bandwidth",
                DependabotUpdateAlertRequestDismissedReason.NotUsed => "not_used",
                DependabotUpdateAlertRequestDismissedReason.TolerableRisk => "tolerable_risk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotUpdateAlertRequestDismissedReason? ToEnum(string value)
        {
            return value switch
            {
                "fix_started" => DependabotUpdateAlertRequestDismissedReason.FixStarted,
                "inaccurate" => DependabotUpdateAlertRequestDismissedReason.Inaccurate,
                "no_bandwidth" => DependabotUpdateAlertRequestDismissedReason.NoBandwidth,
                "not_used" => DependabotUpdateAlertRequestDismissedReason.NotUsed,
                "tolerable_risk" => DependabotUpdateAlertRequestDismissedReason.TolerableRisk,
                _ => null,
            };
        }
    }
}
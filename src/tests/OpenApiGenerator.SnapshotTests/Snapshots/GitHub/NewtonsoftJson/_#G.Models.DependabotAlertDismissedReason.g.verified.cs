//HintName: G.Models.DependabotAlertDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason that the alert was dismissed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotAlertDismissedReason
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
    public static class DependabotAlertDismissedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotAlertDismissedReason value)
        {
            return value switch
            {
                DependabotAlertDismissedReason.FixStarted => "fix_started",
                DependabotAlertDismissedReason.Inaccurate => "inaccurate",
                DependabotAlertDismissedReason.NoBandwidth => "no_bandwidth",
                DependabotAlertDismissedReason.NotUsed => "not_used",
                DependabotAlertDismissedReason.TolerableRisk => "tolerable_risk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotAlertDismissedReason? ToEnum(string value)
        {
            return value switch
            {
                "fix_started" => DependabotAlertDismissedReason.FixStarted,
                "inaccurate" => DependabotAlertDismissedReason.Inaccurate,
                "no_bandwidth" => DependabotAlertDismissedReason.NoBandwidth,
                "not_used" => DependabotAlertDismissedReason.NotUsed,
                "tolerable_risk" => DependabotAlertDismissedReason.TolerableRisk,
                _ => null,
            };
        }
    }
}
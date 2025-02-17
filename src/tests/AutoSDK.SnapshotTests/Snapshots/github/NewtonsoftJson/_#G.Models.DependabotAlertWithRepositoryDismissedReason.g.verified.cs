﻿//HintName: G.Models.DependabotAlertWithRepositoryDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason that the alert was dismissed.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DependabotAlertWithRepositoryDismissedReason
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
    public static class DependabotAlertWithRepositoryDismissedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DependabotAlertWithRepositoryDismissedReason value)
        {
            return value switch
            {
                DependabotAlertWithRepositoryDismissedReason.FixStarted => "fix_started",
                DependabotAlertWithRepositoryDismissedReason.Inaccurate => "inaccurate",
                DependabotAlertWithRepositoryDismissedReason.NoBandwidth => "no_bandwidth",
                DependabotAlertWithRepositoryDismissedReason.NotUsed => "not_used",
                DependabotAlertWithRepositoryDismissedReason.TolerableRisk => "tolerable_risk",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DependabotAlertWithRepositoryDismissedReason? ToEnum(string value)
        {
            return value switch
            {
                "fix_started" => DependabotAlertWithRepositoryDismissedReason.FixStarted,
                "inaccurate" => DependabotAlertWithRepositoryDismissedReason.Inaccurate,
                "no_bandwidth" => DependabotAlertWithRepositoryDismissedReason.NoBandwidth,
                "not_used" => DependabotAlertWithRepositoryDismissedReason.NotUsed,
                "tolerable_risk" => DependabotAlertWithRepositoryDismissedReason.TolerableRisk,
                _ => null,
            };
        }
    }
}
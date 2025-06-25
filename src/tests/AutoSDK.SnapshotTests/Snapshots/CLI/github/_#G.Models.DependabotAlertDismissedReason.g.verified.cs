﻿//HintName: G.Models.DependabotAlertDismissedReason.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The reason that the alert was dismissed.
    /// </summary>
    public enum DependabotAlertDismissedReason
    {
        /// <summary>
        /// 
        /// </summary>
        FixStarted,
        /// <summary>
        /// 
        /// </summary>
        Inaccurate,
        /// <summary>
        /// 
        /// </summary>
        NoBandwidth,
        /// <summary>
        /// 
        /// </summary>
        NotUsed,
        /// <summary>
        /// 
        /// </summary>
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
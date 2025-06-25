﻿//HintName: G.Models.SecurityAndAnalysisDependabotSecurityUpdatesStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Dependabot security updates for the repository.
    /// </summary>
    public enum SecurityAndAnalysisDependabotSecurityUpdatesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecurityAndAnalysisDependabotSecurityUpdatesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAndAnalysisDependabotSecurityUpdatesStatus value)
        {
            return value switch
            {
                SecurityAndAnalysisDependabotSecurityUpdatesStatus.Enabled => "enabled",
                SecurityAndAnalysisDependabotSecurityUpdatesStatus.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAndAnalysisDependabotSecurityUpdatesStatus? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => SecurityAndAnalysisDependabotSecurityUpdatesStatus.Enabled,
                "disabled" => SecurityAndAnalysisDependabotSecurityUpdatesStatus.Disabled,
                _ => null,
            };
        }
    }
}
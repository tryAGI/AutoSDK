﻿//HintName: G.Models.SecurityAndAnalysisSecretScanningStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecurityAndAnalysisSecretScanningStatus
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
    public static class SecurityAndAnalysisSecretScanningStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecurityAndAnalysisSecretScanningStatus value)
        {
            return value switch
            {
                SecurityAndAnalysisSecretScanningStatus.Enabled => "enabled",
                SecurityAndAnalysisSecretScanningStatus.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecurityAndAnalysisSecretScanningStatus? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => SecurityAndAnalysisSecretScanningStatus.Enabled,
                "disabled" => SecurityAndAnalysisSecretScanningStatus.Disabled,
                _ => null,
            };
        }
    }
}
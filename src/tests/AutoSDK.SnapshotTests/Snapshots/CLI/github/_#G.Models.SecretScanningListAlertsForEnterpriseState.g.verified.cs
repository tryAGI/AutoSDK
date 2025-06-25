﻿//HintName: G.Models.SecretScanningListAlertsForEnterpriseState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecretScanningListAlertsForEnterpriseState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Resolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningListAlertsForEnterpriseStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListAlertsForEnterpriseState value)
        {
            return value switch
            {
                SecretScanningListAlertsForEnterpriseState.Open => "open",
                SecretScanningListAlertsForEnterpriseState.Resolved => "resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListAlertsForEnterpriseState? ToEnum(string value)
        {
            return value switch
            {
                "open" => SecretScanningListAlertsForEnterpriseState.Open,
                "resolved" => SecretScanningListAlertsForEnterpriseState.Resolved,
                _ => null,
            };
        }
    }
}
﻿//HintName: G.Models.AppPermissionsSecretScanningAlerts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to view and manage secret scanning alerts.
    /// </summary>
    public enum AppPermissionsSecretScanningAlerts
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPermissionsSecretScanningAlertsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsSecretScanningAlerts value)
        {
            return value switch
            {
                AppPermissionsSecretScanningAlerts.Read => "read",
                AppPermissionsSecretScanningAlerts.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsSecretScanningAlerts? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsSecretScanningAlerts.Read,
                "write" => AppPermissionsSecretScanningAlerts.Write,
                _ => null,
            };
        }
    }
}
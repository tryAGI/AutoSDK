﻿//HintName: G.Models.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts
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
    public static class WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlertsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts value)
        {
            return value switch
            {
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts.Read => "read",
                WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts.Read,
                "write" => WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsSecretScanningAlerts.Write,
                _ => null,
            };
        }
    }
}
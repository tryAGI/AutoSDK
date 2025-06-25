﻿//HintName: G.Models.WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsKeys
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
    public static class WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsKeysExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsKeys value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsKeys.Read => "read",
                WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsKeys.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsKeys? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsKeys.Read,
                "write" => WebhookDeploymentStatusCreatedDeploymentPerformedViaGithubAppPermissionsKeys.Write,
                _ => null,
            };
        }
    }
}
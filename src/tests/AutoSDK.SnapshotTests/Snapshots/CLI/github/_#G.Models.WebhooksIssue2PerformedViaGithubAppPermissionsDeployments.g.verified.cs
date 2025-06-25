﻿//HintName: G.Models.WebhooksIssue2PerformedViaGithubAppPermissionsDeployments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssue2PerformedViaGithubAppPermissionsDeployments
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
    public static class WebhooksIssue2PerformedViaGithubAppPermissionsDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2PerformedViaGithubAppPermissionsDeployments value)
        {
            return value switch
            {
                WebhooksIssue2PerformedViaGithubAppPermissionsDeployments.Read => "read",
                WebhooksIssue2PerformedViaGithubAppPermissionsDeployments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2PerformedViaGithubAppPermissionsDeployments? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhooksIssue2PerformedViaGithubAppPermissionsDeployments.Read,
                "write" => WebhooksIssue2PerformedViaGithubAppPermissionsDeployments.Write,
                _ => null,
            };
        }
    }
}
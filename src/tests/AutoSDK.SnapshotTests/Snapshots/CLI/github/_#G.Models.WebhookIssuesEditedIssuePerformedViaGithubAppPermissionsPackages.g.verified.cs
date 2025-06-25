﻿//HintName: G.Models.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsPackages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsPackages
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
    public static class WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsPackagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsPackages value)
        {
            return value switch
            {
                WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsPackages.Read => "read",
                WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsPackages.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsPackages? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsPackages.Read,
                "write" => WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsPackages.Write,
                _ => null,
            };
        }
    }
}
﻿//HintName: G.Models.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsOrganizationHooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsOrganizationHooks
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
    public static class WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsOrganizationHooksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsOrganizationHooks value)
        {
            return value switch
            {
                WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsOrganizationHooks.Read => "read",
                WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsOrganizationHooks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsOrganizationHooks? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsOrganizationHooks.Read,
                "write" => WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsOrganizationHooks.Write,
                _ => null,
            };
        }
    }
}
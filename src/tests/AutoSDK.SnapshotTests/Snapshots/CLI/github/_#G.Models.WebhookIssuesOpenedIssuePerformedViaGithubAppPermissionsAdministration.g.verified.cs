﻿//HintName: G.Models.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsAdministration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsAdministration
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
    public static class WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsAdministrationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsAdministration value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsAdministration.Read => "read",
                WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsAdministration.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsAdministration? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsAdministration.Read,
                "write" => WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsAdministration.Write,
                _ => null,
            };
        }
    }
}
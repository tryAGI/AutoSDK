﻿//HintName: G.Models.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsIssues.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsIssues
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
    public static class WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsIssuesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsIssues value)
        {
            return value switch
            {
                WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsIssues.Read => "read",
                WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsIssues.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsIssues? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsIssues.Read,
                "write" => WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsIssues.Write,
                _ => null,
            };
        }
    }
}
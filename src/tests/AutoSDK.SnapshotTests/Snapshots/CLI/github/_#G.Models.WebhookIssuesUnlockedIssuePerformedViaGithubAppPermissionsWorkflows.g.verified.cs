﻿//HintName: G.Models.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsWorkflows.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsWorkflows
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
    public static class WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsWorkflowsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsWorkflows value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsWorkflows.Read => "read",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsWorkflows.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsWorkflows? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsWorkflows.Read,
                "write" => WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsWorkflows.Write,
                _ => null,
            };
        }
    }
}
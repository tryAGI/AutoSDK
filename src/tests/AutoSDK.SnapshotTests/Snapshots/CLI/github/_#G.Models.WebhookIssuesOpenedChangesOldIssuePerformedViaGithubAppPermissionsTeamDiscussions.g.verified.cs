﻿//HintName: G.Models.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsTeamDiscussions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsTeamDiscussions
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
    public static class WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsTeamDiscussionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsTeamDiscussions value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsTeamDiscussions.Read => "read",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsTeamDiscussions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsTeamDiscussions? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsTeamDiscussions.Read,
                "write" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsTeamDiscussions.Write,
                _ => null,
            };
        }
    }
}
﻿//HintName: G.Models.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembers
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
    public static class WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembers value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembers.Read => "read",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembers.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembers? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembers.Read,
                "write" => WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembers.Write,
                _ => null,
            };
        }
    }
}
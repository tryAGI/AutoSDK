﻿//HintName: G.Models.WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsKeys
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
    public static class WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsKeysExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsKeys value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsKeys.Read => "read",
                WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsKeys.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsKeys? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsKeys.Read,
                "write" => WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsKeys.Write,
                _ => null,
            };
        }
    }
}
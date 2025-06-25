﻿//HintName: G.Models.WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContentReferences.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContentReferences
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
    public static class WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContentReferencesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContentReferences value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContentReferences.Read => "read",
                WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContentReferences.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContentReferences? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContentReferences.Read,
                "write" => WebhookIssuesReopenedIssuePerformedViaGithubAppPermissionsContentReferences.Write,
                _ => null,
            };
        }
    }
}
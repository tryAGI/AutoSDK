﻿//HintName: G.Models.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsEnvironments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsEnvironments
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
    public static class WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsEnvironmentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsEnvironments value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsEnvironments.Read => "read",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsEnvironments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsEnvironments? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsEnvironments.Read,
                "write" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsEnvironments.Write,
                _ => null,
            };
        }
    }
}
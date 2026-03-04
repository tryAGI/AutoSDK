//HintName: G.Models.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsEnvironments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsEnvironments
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
    public static class WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsEnvironmentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsEnvironments value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsEnvironments.Read => "read",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsEnvironments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsEnvironments? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsEnvironments.Read,
                "write" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsEnvironments.Write,
                _ => null,
            };
        }
    }
}
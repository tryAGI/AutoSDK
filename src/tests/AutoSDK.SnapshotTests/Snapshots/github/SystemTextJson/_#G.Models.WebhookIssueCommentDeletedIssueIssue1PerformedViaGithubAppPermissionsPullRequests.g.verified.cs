//HintName: G.Models.WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsPullRequests.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsPullRequests
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
    public static class WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsPullRequestsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsPullRequests value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsPullRequests.Read => "read",
                WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsPullRequests.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsPullRequests? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsPullRequests.Read,
                "write" => WebhookIssueCommentDeletedIssueIssue1PerformedViaGithubAppPermissionsPullRequests.Write,
                _ => null,
            };
        }
    }
}
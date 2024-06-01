//HintName: G.Models.WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsPullRequests.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsPullRequests
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
    public static class WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsPullRequestsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsPullRequests value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsPullRequests.Read => "read",
                WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsPullRequests.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsPullRequests ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsPullRequests.Read,
                "write" => WebhookIssuesTransferredChangesNewIssuePerformedViaGithubAppPermissionsPullRequests.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
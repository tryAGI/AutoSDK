//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsPullRequests.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsPullRequests
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
    public static class WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsPullRequestsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsPullRequests value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsPullRequests.Read => "read",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsPullRequests.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsPullRequests? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsPullRequests.Read,
                "write" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsPullRequests.Write,
                _ => null,
            };
        }
    }
}
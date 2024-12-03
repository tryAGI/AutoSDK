//HintName: G.Models.WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequests.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequests
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
    public static class WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequestsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequests value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequests.Read => "read",
                WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequests.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequests? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequests.Read,
                "write" => WebhookIssuesLabeledIssuePerformedViaGithubAppPermissionsPullRequests.Write,
                _ => null,
            };
        }
    }
}
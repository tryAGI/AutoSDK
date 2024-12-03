//HintName: G.Models.WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPullRequests.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPullRequests
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPullRequestsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPullRequests value)
        {
            return value switch
            {
                WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPullRequests.Read => "read",
                WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPullRequests.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPullRequests? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPullRequests.Read,
                "write" => WebhookIssuesLockedIssuePerformedViaGithubAppPermissionsPullRequests.Write,
                _ => null,
            };
        }
    }
}
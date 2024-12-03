//HintName: G.Models.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsPullRequests.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsPullRequests
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
    public static class WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsPullRequestsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsPullRequests value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsPullRequests.Read => "read",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsPullRequests.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsPullRequests? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsPullRequests.Read,
                "write" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppPermissionsPullRequests.Write,
                _ => null,
            };
        }
    }
}
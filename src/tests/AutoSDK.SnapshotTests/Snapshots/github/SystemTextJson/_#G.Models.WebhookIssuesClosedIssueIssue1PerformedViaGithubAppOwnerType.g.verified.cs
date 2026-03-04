//HintName: G.Models.WebhookIssuesClosedIssueIssue1PerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueIssue1PerformedViaGithubAppOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesClosedIssueIssue1PerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueIssue1PerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppOwnerType.User => "User",
                WebhookIssuesClosedIssueIssue1PerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueIssue1PerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssuesClosedIssueIssue1PerformedViaGithubAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}
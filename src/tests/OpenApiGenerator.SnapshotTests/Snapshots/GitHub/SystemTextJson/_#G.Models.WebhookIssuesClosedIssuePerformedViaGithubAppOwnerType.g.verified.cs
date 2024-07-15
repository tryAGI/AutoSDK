//HintName: G.Models.WebhookIssuesClosedIssuePerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssuePerformedViaGithubAppOwnerType
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
    public static class WebhookIssuesClosedIssuePerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssuePerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssuePerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssuesClosedIssuePerformedViaGithubAppOwnerType.User => "User",
                WebhookIssuesClosedIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssuePerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssuePerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssuesClosedIssuePerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssuesClosedIssuePerformedViaGithubAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookIssuesLockedIssuePerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLockedIssuePerformedViaGithubAppOwnerType
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
    public static class WebhookIssuesLockedIssuePerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssuePerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssuesLockedIssuePerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssuesLockedIssuePerformedViaGithubAppOwnerType.User => "User",
                WebhookIssuesLockedIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssuePerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesLockedIssuePerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssuesLockedIssuePerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssuesLockedIssuePerformedViaGithubAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}
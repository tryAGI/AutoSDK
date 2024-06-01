//HintName: G.Models.WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType
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
    public static class WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType.User => "User",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
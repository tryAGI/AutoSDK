//HintName: G.Models.WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerType
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
    public static class WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerType.User => "User",
                WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}
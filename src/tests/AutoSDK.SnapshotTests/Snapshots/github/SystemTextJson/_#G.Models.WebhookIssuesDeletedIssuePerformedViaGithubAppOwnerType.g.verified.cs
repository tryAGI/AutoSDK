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
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerType.User => "User",
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
                "Organization" => WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerType.Organization,
                "User" => WebhookIssuesDeletedIssuePerformedViaGithubAppOwnerType.User,
                _ => null,
            };
        }
    }
}
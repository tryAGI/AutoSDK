//HintName: G.Models.WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppOwnerType
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
    public static class WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppOwnerType.User => "User",
                WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssuesOpenedChangesOldIssuePerformedViaGithubAppOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppOwnerType
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
    public static class WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppOwnerType.User => "User",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}
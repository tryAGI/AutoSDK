//HintName: G.Models.WebhookIssueCommentDeletedIssuePerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssuePerformedViaGithubAppOwnerType
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
    public static class WebhookIssueCommentDeletedIssuePerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssuePerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppOwnerType.User => "User",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssuePerformedViaGithubAppOwnerType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppOwnerType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
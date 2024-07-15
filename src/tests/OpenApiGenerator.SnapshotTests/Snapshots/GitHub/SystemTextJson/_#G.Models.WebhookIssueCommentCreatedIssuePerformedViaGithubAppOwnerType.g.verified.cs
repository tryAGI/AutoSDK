//HintName: G.Models.WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType
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
    public static class WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType.User => "User",
                WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssueCommentCreatedIssuePerformedViaGithubAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}
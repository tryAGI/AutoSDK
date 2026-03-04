//HintName: G.Models.WebhookIssueCommentDeletedIssueIssue1UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueIssue1UserType
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
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentDeletedIssueIssue1UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueIssue1UserType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueIssue1UserType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueIssue1UserType.User => "User",
                WebhookIssueCommentDeletedIssueIssue1UserType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueIssue1UserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueIssue1UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueIssue1UserType.Bot,
                "User" => WebhookIssueCommentDeletedIssueIssue1UserType.User,
                "Organization" => WebhookIssueCommentDeletedIssueIssue1UserType.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueIssue1UserType.Mannequin,
                _ => null,
            };
        }
    }
}
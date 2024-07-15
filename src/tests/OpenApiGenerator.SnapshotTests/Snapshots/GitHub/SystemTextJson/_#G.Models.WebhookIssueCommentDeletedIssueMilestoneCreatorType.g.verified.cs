//HintName: G.Models.WebhookIssueCommentDeletedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueMilestoneCreatorType
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
    public static class WebhookIssueCommentDeletedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueMilestoneCreatorType.User => "User",
                WebhookIssueCommentDeletedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssueCommentDeletedIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssueCommentDeletedIssueMilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}
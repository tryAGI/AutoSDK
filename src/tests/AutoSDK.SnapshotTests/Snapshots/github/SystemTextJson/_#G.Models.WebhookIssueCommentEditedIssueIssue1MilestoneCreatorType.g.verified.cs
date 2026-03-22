//HintName: G.Models.WebhookIssueCommentEditedIssueIssue1MilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueIssue1MilestoneCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
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
    public static class WebhookIssueCommentEditedIssueIssue1MilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueIssue1MilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueIssue1MilestoneCreatorType.Bot => "Bot",
                WebhookIssueCommentEditedIssueIssue1MilestoneCreatorType.Mannequin => "Mannequin",
                WebhookIssueCommentEditedIssueIssue1MilestoneCreatorType.Organization => "Organization",
                WebhookIssueCommentEditedIssueIssue1MilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueIssue1MilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueIssue1MilestoneCreatorType.Bot,
                "Mannequin" => WebhookIssueCommentEditedIssueIssue1MilestoneCreatorType.Mannequin,
                "Organization" => WebhookIssueCommentEditedIssueIssue1MilestoneCreatorType.Organization,
                "User" => WebhookIssueCommentEditedIssueIssue1MilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}
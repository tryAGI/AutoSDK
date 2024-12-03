//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1MilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueVariant1MilestoneCreatorType
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
    public static class WebhookIssueCommentEditedIssueVariant1MilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1MilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1MilestoneCreatorType.Bot => "Bot",
                WebhookIssueCommentEditedIssueVariant1MilestoneCreatorType.User => "User",
                WebhookIssueCommentEditedIssueVariant1MilestoneCreatorType.Organization => "Organization",
                WebhookIssueCommentEditedIssueVariant1MilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1MilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueVariant1MilestoneCreatorType.Bot,
                "User" => WebhookIssueCommentEditedIssueVariant1MilestoneCreatorType.User,
                "Organization" => WebhookIssueCommentEditedIssueVariant1MilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssueCommentEditedIssueVariant1MilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}
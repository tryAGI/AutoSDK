//HintName: G.Models.WebhookIssueCommentEditedIssueVariant2AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueVariant2AssigneeType
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
    public static class WebhookIssueCommentEditedIssueVariant2AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant2AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant2AssigneeType.Bot => "Bot",
                WebhookIssueCommentEditedIssueVariant2AssigneeType.Mannequin => "Mannequin",
                WebhookIssueCommentEditedIssueVariant2AssigneeType.Organization => "Organization",
                WebhookIssueCommentEditedIssueVariant2AssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant2AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueVariant2AssigneeType.Bot,
                "Mannequin" => WebhookIssueCommentEditedIssueVariant2AssigneeType.Mannequin,
                "Organization" => WebhookIssueCommentEditedIssueVariant2AssigneeType.Organization,
                "User" => WebhookIssueCommentEditedIssueVariant2AssigneeType.User,
                _ => null,
            };
        }
    }
}
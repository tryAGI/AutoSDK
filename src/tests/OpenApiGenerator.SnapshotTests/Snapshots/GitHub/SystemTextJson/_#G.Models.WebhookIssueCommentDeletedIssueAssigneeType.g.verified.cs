//HintName: G.Models.WebhookIssueCommentDeletedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueAssigneeType
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
    public static class WebhookIssueCommentDeletedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueAssigneeType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueAssigneeType.User => "User",
                WebhookIssueCommentDeletedIssueAssigneeType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueAssigneeType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueAssigneeType.Bot,
                "User" => WebhookIssueCommentDeletedIssueAssigneeType.User,
                "Organization" => WebhookIssueCommentDeletedIssueAssigneeType.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueAssigneeType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
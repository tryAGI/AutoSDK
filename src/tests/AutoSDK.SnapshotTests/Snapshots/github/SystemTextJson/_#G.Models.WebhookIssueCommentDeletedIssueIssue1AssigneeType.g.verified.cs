//HintName: G.Models.WebhookIssueCommentDeletedIssueIssue1AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueIssue1AssigneeType
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
    public static class WebhookIssueCommentDeletedIssueIssue1AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueIssue1AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueIssue1AssigneeType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueIssue1AssigneeType.Mannequin => "Mannequin",
                WebhookIssueCommentDeletedIssueIssue1AssigneeType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueIssue1AssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueIssue1AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueIssue1AssigneeType.Bot,
                "Mannequin" => WebhookIssueCommentDeletedIssueIssue1AssigneeType.Mannequin,
                "Organization" => WebhookIssueCommentDeletedIssueIssue1AssigneeType.Organization,
                "User" => WebhookIssueCommentDeletedIssueIssue1AssigneeType.User,
                _ => null,
            };
        }
    }
}
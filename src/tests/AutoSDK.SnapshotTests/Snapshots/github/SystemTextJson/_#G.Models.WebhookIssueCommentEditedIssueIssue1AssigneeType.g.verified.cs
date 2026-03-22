//HintName: G.Models.WebhookIssueCommentEditedIssueIssue1AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueIssue1AssigneeType
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
    public static class WebhookIssueCommentEditedIssueIssue1AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueIssue1AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueIssue1AssigneeType.Bot => "Bot",
                WebhookIssueCommentEditedIssueIssue1AssigneeType.Mannequin => "Mannequin",
                WebhookIssueCommentEditedIssueIssue1AssigneeType.Organization => "Organization",
                WebhookIssueCommentEditedIssueIssue1AssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueIssue1AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueIssue1AssigneeType.Bot,
                "Mannequin" => WebhookIssueCommentEditedIssueIssue1AssigneeType.Mannequin,
                "Organization" => WebhookIssueCommentEditedIssueIssue1AssigneeType.Organization,
                "User" => WebhookIssueCommentEditedIssueIssue1AssigneeType.User,
                _ => null,
            };
        }
    }
}
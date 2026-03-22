//HintName: G.Models.WebhookIssueCommentEditedIssueIssue1AssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueIssue1AssigneeType2
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
    public static class WebhookIssueCommentEditedIssueIssue1AssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueIssue1AssigneeType2 value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueIssue1AssigneeType2.Bot => "Bot",
                WebhookIssueCommentEditedIssueIssue1AssigneeType2.Mannequin => "Mannequin",
                WebhookIssueCommentEditedIssueIssue1AssigneeType2.Organization => "Organization",
                WebhookIssueCommentEditedIssueIssue1AssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueIssue1AssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueIssue1AssigneeType2.Bot,
                "Mannequin" => WebhookIssueCommentEditedIssueIssue1AssigneeType2.Mannequin,
                "Organization" => WebhookIssueCommentEditedIssueIssue1AssigneeType2.Organization,
                "User" => WebhookIssueCommentEditedIssueIssue1AssigneeType2.User,
                _ => null,
            };
        }
    }
}
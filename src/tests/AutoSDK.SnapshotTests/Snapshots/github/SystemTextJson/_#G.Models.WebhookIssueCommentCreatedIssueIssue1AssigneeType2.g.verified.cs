//HintName: G.Models.WebhookIssueCommentCreatedIssueIssue1AssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueIssue1AssigneeType2
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
    public static class WebhookIssueCommentCreatedIssueIssue1AssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueIssue1AssigneeType2 value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueIssue1AssigneeType2.Bot => "Bot",
                WebhookIssueCommentCreatedIssueIssue1AssigneeType2.User => "User",
                WebhookIssueCommentCreatedIssueIssue1AssigneeType2.Organization => "Organization",
                WebhookIssueCommentCreatedIssueIssue1AssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueIssue1AssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueIssue1AssigneeType2.Bot,
                "User" => WebhookIssueCommentCreatedIssueIssue1AssigneeType2.User,
                "Organization" => WebhookIssueCommentCreatedIssueIssue1AssigneeType2.Organization,
                "Mannequin" => WebhookIssueCommentCreatedIssueIssue1AssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}
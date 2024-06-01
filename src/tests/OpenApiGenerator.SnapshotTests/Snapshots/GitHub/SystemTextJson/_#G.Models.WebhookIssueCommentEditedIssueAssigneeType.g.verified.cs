//HintName: G.Models.WebhookIssueCommentEditedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueAssigneeType
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
    public static class WebhookIssueCommentEditedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueAssigneeType.Bot => "Bot",
                WebhookIssueCommentEditedIssueAssigneeType.User => "User",
                WebhookIssueCommentEditedIssueAssigneeType.Organization => "Organization",
                WebhookIssueCommentEditedIssueAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueAssigneeType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueAssigneeType.Bot,
                "User" => WebhookIssueCommentEditedIssueAssigneeType.User,
                "Organization" => WebhookIssueCommentEditedIssueAssigneeType.Organization,
                "Mannequin" => WebhookIssueCommentEditedIssueAssigneeType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
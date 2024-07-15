//HintName: G.Models.WebhookIssueCommentCreatedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueAssigneeType
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
    public static class WebhookIssueCommentCreatedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueAssigneeType.Bot => "Bot",
                WebhookIssueCommentCreatedIssueAssigneeType.User => "User",
                WebhookIssueCommentCreatedIssueAssigneeType.Organization => "Organization",
                WebhookIssueCommentCreatedIssueAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueAssigneeType.Bot,
                "User" => WebhookIssueCommentCreatedIssueAssigneeType.User,
                "Organization" => WebhookIssueCommentCreatedIssueAssigneeType.Organization,
                "Mannequin" => WebhookIssueCommentCreatedIssueAssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}
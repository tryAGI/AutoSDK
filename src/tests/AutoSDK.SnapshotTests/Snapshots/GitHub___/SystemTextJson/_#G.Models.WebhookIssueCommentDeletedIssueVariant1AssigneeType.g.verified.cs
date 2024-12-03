//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueVariant1AssigneeType
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
    public static class WebhookIssueCommentDeletedIssueVariant1AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1AssigneeType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1AssigneeType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueVariant1AssigneeType.User => "User",
                WebhookIssueCommentDeletedIssueVariant1AssigneeType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueVariant1AssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueVariant1AssigneeType.Bot,
                "User" => WebhookIssueCommentDeletedIssueVariant1AssigneeType.User,
                "Organization" => WebhookIssueCommentDeletedIssueVariant1AssigneeType.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueVariant1AssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookIssueCommentDeletedIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueAssigneesType
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
    public static class WebhookIssueCommentDeletedIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueAssigneesType.Bot => "Bot",
                WebhookIssueCommentDeletedIssueAssigneesType.User => "User",
                WebhookIssueCommentDeletedIssueAssigneesType.Organization => "Organization",
                WebhookIssueCommentDeletedIssueAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueAssigneesType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentDeletedIssueAssigneesType.Bot,
                "User" => WebhookIssueCommentDeletedIssueAssigneesType.User,
                "Organization" => WebhookIssueCommentDeletedIssueAssigneesType.Organization,
                "Mannequin" => WebhookIssueCommentDeletedIssueAssigneesType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
//HintName: G.Models.WebhookIssueCommentEditedIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueAssigneesType
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
    public static class WebhookIssueCommentEditedIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueAssigneesType.Bot => "Bot",
                WebhookIssueCommentEditedIssueAssigneesType.User => "User",
                WebhookIssueCommentEditedIssueAssigneesType.Organization => "Organization",
                WebhookIssueCommentEditedIssueAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueAssigneesType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueAssigneesType.Bot,
                "User" => WebhookIssueCommentEditedIssueAssigneesType.User,
                "Organization" => WebhookIssueCommentEditedIssueAssigneesType.Organization,
                "Mannequin" => WebhookIssueCommentEditedIssueAssigneesType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
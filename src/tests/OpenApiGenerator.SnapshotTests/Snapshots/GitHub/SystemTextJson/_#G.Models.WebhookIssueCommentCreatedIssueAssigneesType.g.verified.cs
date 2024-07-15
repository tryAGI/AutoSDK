//HintName: G.Models.WebhookIssueCommentCreatedIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueAssigneesType
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
    public static class WebhookIssueCommentCreatedIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueAssigneesType.Bot => "Bot",
                WebhookIssueCommentCreatedIssueAssigneesType.User => "User",
                WebhookIssueCommentCreatedIssueAssigneesType.Organization => "Organization",
                WebhookIssueCommentCreatedIssueAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueAssigneesType.Bot,
                "User" => WebhookIssueCommentCreatedIssueAssigneesType.User,
                "Organization" => WebhookIssueCommentCreatedIssueAssigneesType.Organization,
                "Mannequin" => WebhookIssueCommentCreatedIssueAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}
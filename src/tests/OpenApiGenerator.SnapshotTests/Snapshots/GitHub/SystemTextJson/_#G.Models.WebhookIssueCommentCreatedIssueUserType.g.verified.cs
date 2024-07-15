//HintName: G.Models.WebhookIssueCommentCreatedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueUserType
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
    public static class WebhookIssueCommentCreatedIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueUserType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueUserType.Bot => "Bot",
                WebhookIssueCommentCreatedIssueUserType.User => "User",
                WebhookIssueCommentCreatedIssueUserType.Organization => "Organization",
                WebhookIssueCommentCreatedIssueUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueUserType.Bot,
                "User" => WebhookIssueCommentCreatedIssueUserType.User,
                "Organization" => WebhookIssueCommentCreatedIssueUserType.Organization,
                "Mannequin" => WebhookIssueCommentCreatedIssueUserType.Mannequin,
                _ => null,
            };
        }
    }
}
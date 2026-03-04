//HintName: G.Models.WebhookIssueCommentCreatedIssueIssue1UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueIssue1UserType
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
    public static class WebhookIssueCommentCreatedIssueIssue1UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueIssue1UserType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueIssue1UserType.Bot => "Bot",
                WebhookIssueCommentCreatedIssueIssue1UserType.User => "User",
                WebhookIssueCommentCreatedIssueIssue1UserType.Organization => "Organization",
                WebhookIssueCommentCreatedIssueIssue1UserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueIssue1UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueIssue1UserType.Bot,
                "User" => WebhookIssueCommentCreatedIssueIssue1UserType.User,
                "Organization" => WebhookIssueCommentCreatedIssueIssue1UserType.Organization,
                "Mannequin" => WebhookIssueCommentCreatedIssueIssue1UserType.Mannequin,
                _ => null,
            };
        }
    }
}
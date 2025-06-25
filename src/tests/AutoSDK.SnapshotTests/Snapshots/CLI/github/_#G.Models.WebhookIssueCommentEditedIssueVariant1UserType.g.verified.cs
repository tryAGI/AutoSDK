//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueVariant1UserType
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
    public static class WebhookIssueCommentEditedIssueVariant1UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1UserType value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1UserType.Bot => "Bot",
                WebhookIssueCommentEditedIssueVariant1UserType.User => "User",
                WebhookIssueCommentEditedIssueVariant1UserType.Organization => "Organization",
                WebhookIssueCommentEditedIssueVariant1UserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueVariant1UserType.Bot,
                "User" => WebhookIssueCommentEditedIssueVariant1UserType.User,
                "Organization" => WebhookIssueCommentEditedIssueVariant1UserType.Organization,
                "Mannequin" => WebhookIssueCommentEditedIssueVariant1UserType.Mannequin,
                _ => null,
            };
        }
    }
}
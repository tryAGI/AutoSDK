//HintName: G.Models.WebhookIssuesEditedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesEditedIssueUserType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesEditedIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssueUserType value)
        {
            return value switch
            {
                WebhookIssuesEditedIssueUserType.Bot => "Bot",
                WebhookIssuesEditedIssueUserType.Mannequin => "Mannequin",
                WebhookIssuesEditedIssueUserType.Organization => "Organization",
                WebhookIssuesEditedIssueUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssueUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesEditedIssueUserType.Bot,
                "Mannequin" => WebhookIssuesEditedIssueUserType.Mannequin,
                "Organization" => WebhookIssuesEditedIssueUserType.Organization,
                "User" => WebhookIssuesEditedIssueUserType.User,
                _ => null,
            };
        }
    }
}
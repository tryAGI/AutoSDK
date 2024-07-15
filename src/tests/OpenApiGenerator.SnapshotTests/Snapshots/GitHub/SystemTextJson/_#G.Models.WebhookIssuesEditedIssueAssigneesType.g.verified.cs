//HintName: G.Models.WebhookIssuesEditedIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesEditedIssueAssigneesType
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
    public static class WebhookIssuesEditedIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssuesEditedIssueAssigneesType.Bot => "Bot",
                WebhookIssuesEditedIssueAssigneesType.User => "User",
                WebhookIssuesEditedIssueAssigneesType.Organization => "Organization",
                WebhookIssuesEditedIssueAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssueAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesEditedIssueAssigneesType.Bot,
                "User" => WebhookIssuesEditedIssueAssigneesType.User,
                "Organization" => WebhookIssuesEditedIssueAssigneesType.Organization,
                "Mannequin" => WebhookIssuesEditedIssueAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}
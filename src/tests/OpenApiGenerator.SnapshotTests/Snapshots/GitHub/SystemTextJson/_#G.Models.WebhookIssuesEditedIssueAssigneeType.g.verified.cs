//HintName: G.Models.WebhookIssuesEditedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesEditedIssueAssigneeType
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
    public static class WebhookIssuesEditedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesEditedIssueAssigneeType.Bot => "Bot",
                WebhookIssuesEditedIssueAssigneeType.User => "User",
                WebhookIssuesEditedIssueAssigneeType.Organization => "Organization",
                WebhookIssuesEditedIssueAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssueAssigneeType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesEditedIssueAssigneeType.Bot,
                "User" => WebhookIssuesEditedIssueAssigneeType.User,
                "Organization" => WebhookIssuesEditedIssueAssigneeType.Organization,
                "Mannequin" => WebhookIssuesEditedIssueAssigneeType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
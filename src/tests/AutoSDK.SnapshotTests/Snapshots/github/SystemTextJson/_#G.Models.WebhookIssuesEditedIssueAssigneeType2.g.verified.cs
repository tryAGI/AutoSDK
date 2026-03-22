//HintName: G.Models.WebhookIssuesEditedIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesEditedIssueAssigneeType2
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
    public static class WebhookIssuesEditedIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesEditedIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesEditedIssueAssigneeType2.Mannequin => "Mannequin",
                WebhookIssuesEditedIssueAssigneeType2.Organization => "Organization",
                WebhookIssuesEditedIssueAssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesEditedIssueAssigneeType2.Bot,
                "Mannequin" => WebhookIssuesEditedIssueAssigneeType2.Mannequin,
                "Organization" => WebhookIssuesEditedIssueAssigneeType2.Organization,
                "User" => WebhookIssuesEditedIssueAssigneeType2.User,
                _ => null,
            };
        }
    }
}
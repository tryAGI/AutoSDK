//HintName: G.Models.WebhookIssuesLabeledIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLabeledIssueAssigneeType2
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
    public static class WebhookIssuesLabeledIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesLabeledIssueAssigneeType2.User => "User",
                WebhookIssuesLabeledIssueAssigneeType2.Organization => "Organization",
                WebhookIssuesLabeledIssueAssigneeType2.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesLabeledIssueAssigneeType2.Bot,
                "User" => WebhookIssuesLabeledIssueAssigneeType2.User,
                "Organization" => WebhookIssuesLabeledIssueAssigneeType2.Organization,
                "Mannequin" => WebhookIssuesLabeledIssueAssigneeType2.Mannequin,
                _ => null,
            };
        }
    }
}
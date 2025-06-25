//HintName: G.Models.WebhookIssuesClosedIssueVariant1AssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueVariant1AssigneeType
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
    public static class WebhookIssuesClosedIssueVariant1AssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant1AssigneeType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant1AssigneeType.Bot => "Bot",
                WebhookIssuesClosedIssueVariant1AssigneeType.User => "User",
                WebhookIssuesClosedIssueVariant1AssigneeType.Organization => "Organization",
                WebhookIssuesClosedIssueVariant1AssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant1AssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueVariant1AssigneeType.Bot,
                "User" => WebhookIssuesClosedIssueVariant1AssigneeType.User,
                "Organization" => WebhookIssuesClosedIssueVariant1AssigneeType.Organization,
                "Mannequin" => WebhookIssuesClosedIssueVariant1AssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}
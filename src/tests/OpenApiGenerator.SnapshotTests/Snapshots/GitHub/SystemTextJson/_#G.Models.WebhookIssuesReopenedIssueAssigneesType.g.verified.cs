//HintName: G.Models.WebhookIssuesReopenedIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesReopenedIssueAssigneesType
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
    public static class WebhookIssuesReopenedIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssueAssigneesType.Bot => "Bot",
                WebhookIssuesReopenedIssueAssigneesType.User => "User",
                WebhookIssuesReopenedIssueAssigneesType.Organization => "Organization",
                WebhookIssuesReopenedIssueAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssueAssigneesType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesReopenedIssueAssigneesType.Bot,
                "User" => WebhookIssuesReopenedIssueAssigneesType.User,
                "Organization" => WebhookIssuesReopenedIssueAssigneesType.Organization,
                "Mannequin" => WebhookIssuesReopenedIssueAssigneesType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
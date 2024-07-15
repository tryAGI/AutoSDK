//HintName: G.Models.WebhookIssuesClosedIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueAssigneesType
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
    public static class WebhookIssuesClosedIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueAssigneesType.Bot => "Bot",
                WebhookIssuesClosedIssueAssigneesType.User => "User",
                WebhookIssuesClosedIssueAssigneesType.Organization => "Organization",
                WebhookIssuesClosedIssueAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueAssigneesType.Bot,
                "User" => WebhookIssuesClosedIssueAssigneesType.User,
                "Organization" => WebhookIssuesClosedIssueAssigneesType.Organization,
                "Mannequin" => WebhookIssuesClosedIssueAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}
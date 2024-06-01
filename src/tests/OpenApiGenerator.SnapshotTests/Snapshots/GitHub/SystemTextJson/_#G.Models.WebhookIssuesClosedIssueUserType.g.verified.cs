//HintName: G.Models.WebhookIssuesClosedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueUserType
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
    public static class WebhookIssuesClosedIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueUserType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueUserType.Bot => "Bot",
                WebhookIssuesClosedIssueUserType.User => "User",
                WebhookIssuesClosedIssueUserType.Organization => "Organization",
                WebhookIssuesClosedIssueUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueUserType.Bot,
                "User" => WebhookIssuesClosedIssueUserType.User,
                "Organization" => WebhookIssuesClosedIssueUserType.Organization,
                "Mannequin" => WebhookIssuesClosedIssueUserType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
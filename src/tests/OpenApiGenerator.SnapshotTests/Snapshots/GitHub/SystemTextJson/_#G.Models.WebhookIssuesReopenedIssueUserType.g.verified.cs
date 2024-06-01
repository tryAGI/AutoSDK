//HintName: G.Models.WebhookIssuesReopenedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesReopenedIssueUserType
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
    public static class WebhookIssuesReopenedIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssueUserType value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssueUserType.Bot => "Bot",
                WebhookIssuesReopenedIssueUserType.User => "User",
                WebhookIssuesReopenedIssueUserType.Organization => "Organization",
                WebhookIssuesReopenedIssueUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssueUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesReopenedIssueUserType.Bot,
                "User" => WebhookIssuesReopenedIssueUserType.User,
                "Organization" => WebhookIssuesReopenedIssueUserType.Organization,
                "Mannequin" => WebhookIssuesReopenedIssueUserType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
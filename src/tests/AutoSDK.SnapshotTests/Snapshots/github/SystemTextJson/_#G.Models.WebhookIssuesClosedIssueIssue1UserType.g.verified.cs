//HintName: G.Models.WebhookIssuesClosedIssueIssue1UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueIssue1UserType
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
    public static class WebhookIssuesClosedIssueIssue1UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueIssue1UserType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueIssue1UserType.Bot => "Bot",
                WebhookIssuesClosedIssueIssue1UserType.Mannequin => "Mannequin",
                WebhookIssuesClosedIssueIssue1UserType.Organization => "Organization",
                WebhookIssuesClosedIssueIssue1UserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueIssue1UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueIssue1UserType.Bot,
                "Mannequin" => WebhookIssuesClosedIssueIssue1UserType.Mannequin,
                "Organization" => WebhookIssuesClosedIssueIssue1UserType.Organization,
                "User" => WebhookIssuesClosedIssueIssue1UserType.User,
                _ => null,
            };
        }
    }
}
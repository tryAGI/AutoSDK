//HintName: G.Models.WebhookIssuesClosedIssueVariant1UserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesClosedIssueVariant1UserType
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
    public static class WebhookIssuesClosedIssueVariant1UserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant1UserType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant1UserType.Bot => "Bot",
                WebhookIssuesClosedIssueVariant1UserType.User => "User",
                WebhookIssuesClosedIssueVariant1UserType.Organization => "Organization",
                WebhookIssuesClosedIssueVariant1UserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant1UserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueVariant1UserType.Bot,
                "User" => WebhookIssuesClosedIssueVariant1UserType.User,
                "Organization" => WebhookIssuesClosedIssueVariant1UserType.Organization,
                "Mannequin" => WebhookIssuesClosedIssueVariant1UserType.Mannequin,
                _ => null,
            };
        }
    }
}
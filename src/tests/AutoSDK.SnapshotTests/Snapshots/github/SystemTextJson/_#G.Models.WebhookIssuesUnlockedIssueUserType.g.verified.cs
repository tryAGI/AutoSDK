//HintName: G.Models.WebhookIssuesUnlockedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlockedIssueUserType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
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
    public static class WebhookIssuesUnlockedIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssueUserType value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssueUserType.Bot => "Bot",
                WebhookIssuesUnlockedIssueUserType.Organization => "Organization",
                WebhookIssuesUnlockedIssueUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssueUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesUnlockedIssueUserType.Bot,
                "Organization" => WebhookIssuesUnlockedIssueUserType.Organization,
                "User" => WebhookIssuesUnlockedIssueUserType.User,
                _ => null,
            };
        }
    }
}
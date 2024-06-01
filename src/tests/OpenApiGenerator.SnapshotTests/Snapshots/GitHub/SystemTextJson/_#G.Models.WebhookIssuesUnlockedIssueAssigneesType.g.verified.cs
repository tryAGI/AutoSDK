//HintName: G.Models.WebhookIssuesUnlockedIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlockedIssueAssigneesType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesUnlockedIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssueAssigneesType.Bot => "Bot",
                WebhookIssuesUnlockedIssueAssigneesType.User => "User",
                WebhookIssuesUnlockedIssueAssigneesType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssueAssigneesType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesUnlockedIssueAssigneesType.Bot,
                "User" => WebhookIssuesUnlockedIssueAssigneesType.User,
                "Organization" => WebhookIssuesUnlockedIssueAssigneesType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
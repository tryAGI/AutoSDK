//HintName: G.Models.WebhookIssuesUnlockedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlockedIssueAssigneeType
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
    public static class WebhookIssuesUnlockedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssueAssigneeType.Bot => "Bot",
                WebhookIssuesUnlockedIssueAssigneeType.User => "User",
                WebhookIssuesUnlockedIssueAssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssueAssigneeType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesUnlockedIssueAssigneeType.Bot,
                "User" => WebhookIssuesUnlockedIssueAssigneeType.User,
                "Organization" => WebhookIssuesUnlockedIssueAssigneeType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
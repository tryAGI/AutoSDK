//HintName: G.Models.WebhookIssuesUnlockedIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesUnlockedIssueAssigneeType2
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
    public static class WebhookIssuesUnlockedIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesUnlockedIssueAssigneeType2.User => "User",
                WebhookIssuesUnlockedIssueAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesUnlockedIssueAssigneeType2.Bot,
                "User" => WebhookIssuesUnlockedIssueAssigneeType2.User,
                "Organization" => WebhookIssuesUnlockedIssueAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}
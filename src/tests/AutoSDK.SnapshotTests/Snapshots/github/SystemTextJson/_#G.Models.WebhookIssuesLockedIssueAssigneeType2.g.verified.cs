//HintName: G.Models.WebhookIssuesLockedIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLockedIssueAssigneeType2
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
    public static class WebhookIssuesLockedIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesLockedIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesLockedIssueAssigneeType2.Organization => "Organization",
                WebhookIssuesLockedIssueAssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesLockedIssueAssigneeType2.Bot,
                "Organization" => WebhookIssuesLockedIssueAssigneeType2.Organization,
                "User" => WebhookIssuesLockedIssueAssigneeType2.User,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookIssuesLockedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLockedIssueAssigneeType
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
    public static class WebhookIssuesLockedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesLockedIssueAssigneeType.Bot => "Bot",
                WebhookIssuesLockedIssueAssigneeType.Organization => "Organization",
                WebhookIssuesLockedIssueAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesLockedIssueAssigneeType.Bot,
                "Organization" => WebhookIssuesLockedIssueAssigneeType.Organization,
                "User" => WebhookIssuesLockedIssueAssigneeType.User,
                _ => null,
            };
        }
    }
}
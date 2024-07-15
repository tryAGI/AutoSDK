//HintName: G.Models.WebhookIssuesLockedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLockedIssueUserType
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
    public static class WebhookIssuesLockedIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssueUserType value)
        {
            return value switch
            {
                WebhookIssuesLockedIssueUserType.Bot => "Bot",
                WebhookIssuesLockedIssueUserType.User => "User",
                WebhookIssuesLockedIssueUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssueUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesLockedIssueUserType.Bot,
                "User" => WebhookIssuesLockedIssueUserType.User,
                "Organization" => WebhookIssuesLockedIssueUserType.Organization,
                _ => null,
            };
        }
    }
}
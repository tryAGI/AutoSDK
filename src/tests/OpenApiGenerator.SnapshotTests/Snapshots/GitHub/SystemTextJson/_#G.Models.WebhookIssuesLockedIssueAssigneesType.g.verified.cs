//HintName: G.Models.WebhookIssuesLockedIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLockedIssueAssigneesType
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
    public static class WebhookIssuesLockedIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssuesLockedIssueAssigneesType.Bot => "Bot",
                WebhookIssuesLockedIssueAssigneesType.User => "User",
                WebhookIssuesLockedIssueAssigneesType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssueAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesLockedIssueAssigneesType.Bot,
                "User" => WebhookIssuesLockedIssueAssigneesType.User,
                "Organization" => WebhookIssuesLockedIssueAssigneesType.Organization,
                _ => null,
            };
        }
    }
}
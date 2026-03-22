//HintName: G.Models.WebhookIssuesDeletedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDeletedIssueUserType
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
    public static class WebhookIssuesDeletedIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssueUserType value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssueUserType.Bot => "Bot",
                WebhookIssuesDeletedIssueUserType.Organization => "Organization",
                WebhookIssuesDeletedIssueUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssueUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDeletedIssueUserType.Bot,
                "Organization" => WebhookIssuesDeletedIssueUserType.Organization,
                "User" => WebhookIssuesDeletedIssueUserType.User,
                _ => null,
            };
        }
    }
}
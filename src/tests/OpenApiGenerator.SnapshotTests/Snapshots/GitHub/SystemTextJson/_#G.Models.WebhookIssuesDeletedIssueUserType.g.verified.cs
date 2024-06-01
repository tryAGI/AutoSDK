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
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
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
                WebhookIssuesDeletedIssueUserType.User => "User",
                WebhookIssuesDeletedIssueUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssueUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDeletedIssueUserType.Bot,
                "User" => WebhookIssuesDeletedIssueUserType.User,
                "Organization" => WebhookIssuesDeletedIssueUserType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
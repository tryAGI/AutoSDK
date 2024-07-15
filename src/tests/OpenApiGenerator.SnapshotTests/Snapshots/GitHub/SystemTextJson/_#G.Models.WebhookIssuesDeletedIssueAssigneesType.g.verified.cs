//HintName: G.Models.WebhookIssuesDeletedIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDeletedIssueAssigneesType
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
    public static class WebhookIssuesDeletedIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssueAssigneesType.Bot => "Bot",
                WebhookIssuesDeletedIssueAssigneesType.User => "User",
                WebhookIssuesDeletedIssueAssigneesType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssueAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDeletedIssueAssigneesType.Bot,
                "User" => WebhookIssuesDeletedIssueAssigneesType.User,
                "Organization" => WebhookIssuesDeletedIssueAssigneesType.Organization,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookIssuesDeletedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDeletedIssueAssigneeType
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
    public static class WebhookIssuesDeletedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssueAssigneeType.Bot => "Bot",
                WebhookIssuesDeletedIssueAssigneeType.User => "User",
                WebhookIssuesDeletedIssueAssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDeletedIssueAssigneeType.Bot,
                "User" => WebhookIssuesDeletedIssueAssigneeType.User,
                "Organization" => WebhookIssuesDeletedIssueAssigneeType.Organization,
                _ => null,
            };
        }
    }
}
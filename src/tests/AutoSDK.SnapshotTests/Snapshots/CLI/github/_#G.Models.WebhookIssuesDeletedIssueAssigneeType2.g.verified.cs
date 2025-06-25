//HintName: G.Models.WebhookIssuesDeletedIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDeletedIssueAssigneeType2
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
    public static class WebhookIssuesDeletedIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesDeletedIssueAssigneeType2.User => "User",
                WebhookIssuesDeletedIssueAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDeletedIssueAssigneeType2.Bot,
                "User" => WebhookIssuesDeletedIssueAssigneeType2.User,
                "Organization" => WebhookIssuesDeletedIssueAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}
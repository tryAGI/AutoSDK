//HintName: G.Models.WebhookIssuesOpenedChangesOldIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedChangesOldIssueAssigneeType2
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
    public static class WebhookIssuesOpenedChangesOldIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesOpenedChangesOldIssueAssigneeType2.User => "User",
                WebhookIssuesOpenedChangesOldIssueAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedChangesOldIssueAssigneeType2.Bot,
                "User" => WebhookIssuesOpenedChangesOldIssueAssigneeType2.User,
                "Organization" => WebhookIssuesOpenedChangesOldIssueAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}
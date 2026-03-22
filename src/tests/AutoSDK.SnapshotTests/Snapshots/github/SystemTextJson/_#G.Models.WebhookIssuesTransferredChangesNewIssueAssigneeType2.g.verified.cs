//HintName: G.Models.WebhookIssuesTransferredChangesNewIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewIssueAssigneeType2
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
    public static class WebhookIssuesTransferredChangesNewIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesTransferredChangesNewIssueAssigneeType2.Organization => "Organization",
                WebhookIssuesTransferredChangesNewIssueAssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesTransferredChangesNewIssueAssigneeType2.Bot,
                "Organization" => WebhookIssuesTransferredChangesNewIssueAssigneeType2.Organization,
                "User" => WebhookIssuesTransferredChangesNewIssueAssigneeType2.User,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookIssuesTransferredChangesNewIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewIssueAssigneeType
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
    public static class WebhookIssuesTransferredChangesNewIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssueAssigneeType.Bot => "Bot",
                WebhookIssuesTransferredChangesNewIssueAssigneeType.User => "User",
                WebhookIssuesTransferredChangesNewIssueAssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesTransferredChangesNewIssueAssigneeType.Bot,
                "User" => WebhookIssuesTransferredChangesNewIssueAssigneeType.User,
                "Organization" => WebhookIssuesTransferredChangesNewIssueAssigneeType.Organization,
                _ => null,
            };
        }
    }
}
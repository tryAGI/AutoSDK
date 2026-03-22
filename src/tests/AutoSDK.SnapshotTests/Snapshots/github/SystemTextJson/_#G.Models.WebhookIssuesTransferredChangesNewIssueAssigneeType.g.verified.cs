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
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                WebhookIssuesTransferredChangesNewIssueAssigneeType.Organization => "Organization",
                WebhookIssuesTransferredChangesNewIssueAssigneeType.User => "User",
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
                "Organization" => WebhookIssuesTransferredChangesNewIssueAssigneeType.Organization,
                "User" => WebhookIssuesTransferredChangesNewIssueAssigneeType.User,
                _ => null,
            };
        }
    }
}
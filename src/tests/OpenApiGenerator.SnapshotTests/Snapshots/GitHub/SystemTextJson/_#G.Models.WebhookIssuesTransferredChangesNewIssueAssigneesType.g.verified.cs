//HintName: G.Models.WebhookIssuesTransferredChangesNewIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewIssueAssigneesType
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
    public static class WebhookIssuesTransferredChangesNewIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssueAssigneesType.Bot => "Bot",
                WebhookIssuesTransferredChangesNewIssueAssigneesType.User => "User",
                WebhookIssuesTransferredChangesNewIssueAssigneesType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssueAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesTransferredChangesNewIssueAssigneesType.Bot,
                "User" => WebhookIssuesTransferredChangesNewIssueAssigneesType.User,
                "Organization" => WebhookIssuesTransferredChangesNewIssueAssigneesType.Organization,
                _ => null,
            };
        }
    }
}
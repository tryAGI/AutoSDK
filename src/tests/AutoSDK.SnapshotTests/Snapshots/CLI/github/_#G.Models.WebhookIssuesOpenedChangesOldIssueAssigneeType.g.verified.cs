//HintName: G.Models.WebhookIssuesOpenedChangesOldIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedChangesOldIssueAssigneeType
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
    public static class WebhookIssuesOpenedChangesOldIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssueAssigneeType.Bot => "Bot",
                WebhookIssuesOpenedChangesOldIssueAssigneeType.User => "User",
                WebhookIssuesOpenedChangesOldIssueAssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedChangesOldIssueAssigneeType.Bot,
                "User" => WebhookIssuesOpenedChangesOldIssueAssigneeType.User,
                "Organization" => WebhookIssuesOpenedChangesOldIssueAssigneeType.Organization,
                _ => null,
            };
        }
    }
}
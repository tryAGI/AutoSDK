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
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                WebhookIssuesOpenedChangesOldIssueAssigneeType.Organization => "Organization",
                WebhookIssuesOpenedChangesOldIssueAssigneeType.User => "User",
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
                "Organization" => WebhookIssuesOpenedChangesOldIssueAssigneeType.Organization,
                "User" => WebhookIssuesOpenedChangesOldIssueAssigneeType.User,
                _ => null,
            };
        }
    }
}
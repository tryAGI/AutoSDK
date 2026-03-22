//HintName: G.Models.WebhookIssuesOpenedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedIssueAssigneeType
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
    public static class WebhookIssuesOpenedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssueAssigneeType.Bot => "Bot",
                WebhookIssuesOpenedIssueAssigneeType.Organization => "Organization",
                WebhookIssuesOpenedIssueAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedIssueAssigneeType.Bot,
                "Organization" => WebhookIssuesOpenedIssueAssigneeType.Organization,
                "User" => WebhookIssuesOpenedIssueAssigneeType.User,
                _ => null,
            };
        }
    }
}
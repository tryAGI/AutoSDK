//HintName: G.Models.WebhookIssuesOpenedChangesOldIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedChangesOldIssueAssigneesType
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
    public static class WebhookIssuesOpenedChangesOldIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssueAssigneesType.Bot => "Bot",
                WebhookIssuesOpenedChangesOldIssueAssigneesType.User => "User",
                WebhookIssuesOpenedChangesOldIssueAssigneesType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssueAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedChangesOldIssueAssigneesType.Bot,
                "User" => WebhookIssuesOpenedChangesOldIssueAssigneesType.User,
                "Organization" => WebhookIssuesOpenedChangesOldIssueAssigneesType.Organization,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookIssuesOpenedChangesOldIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedChangesOldIssueUserType
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
    public static class WebhookIssuesOpenedChangesOldIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssueUserType value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssueUserType.Bot => "Bot",
                WebhookIssuesOpenedChangesOldIssueUserType.User => "User",
                WebhookIssuesOpenedChangesOldIssueUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssueUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedChangesOldIssueUserType.Bot,
                "User" => WebhookIssuesOpenedChangesOldIssueUserType.User,
                "Organization" => WebhookIssuesOpenedChangesOldIssueUserType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
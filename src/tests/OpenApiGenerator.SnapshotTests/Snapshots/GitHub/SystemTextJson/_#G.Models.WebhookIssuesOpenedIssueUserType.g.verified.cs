//HintName: G.Models.WebhookIssuesOpenedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedIssueUserType
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
    public static class WebhookIssuesOpenedIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssueUserType value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssueUserType.Bot => "Bot",
                WebhookIssuesOpenedIssueUserType.User => "User",
                WebhookIssuesOpenedIssueUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssueUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedIssueUserType.Bot,
                "User" => WebhookIssuesOpenedIssueUserType.User,
                "Organization" => WebhookIssuesOpenedIssueUserType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
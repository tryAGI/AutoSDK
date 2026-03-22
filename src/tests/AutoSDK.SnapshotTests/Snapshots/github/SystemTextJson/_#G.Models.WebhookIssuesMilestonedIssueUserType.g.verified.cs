//HintName: G.Models.WebhookIssuesMilestonedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesMilestonedIssueUserType
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
    public static class WebhookIssuesMilestonedIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssueUserType value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssueUserType.Bot => "Bot",
                WebhookIssuesMilestonedIssueUserType.Organization => "Organization",
                WebhookIssuesMilestonedIssueUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssueUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesMilestonedIssueUserType.Bot,
                "Organization" => WebhookIssuesMilestonedIssueUserType.Organization,
                "User" => WebhookIssuesMilestonedIssueUserType.User,
                _ => null,
            };
        }
    }
}
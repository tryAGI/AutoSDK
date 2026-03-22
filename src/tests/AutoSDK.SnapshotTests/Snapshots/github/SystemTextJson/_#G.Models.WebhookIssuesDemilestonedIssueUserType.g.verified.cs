//HintName: G.Models.WebhookIssuesDemilestonedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDemilestonedIssueUserType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
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
    public static class WebhookIssuesDemilestonedIssueUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssueUserType value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssueUserType.Bot => "Bot",
                WebhookIssuesDemilestonedIssueUserType.Mannequin => "Mannequin",
                WebhookIssuesDemilestonedIssueUserType.Organization => "Organization",
                WebhookIssuesDemilestonedIssueUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssueUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDemilestonedIssueUserType.Bot,
                "Mannequin" => WebhookIssuesDemilestonedIssueUserType.Mannequin,
                "Organization" => WebhookIssuesDemilestonedIssueUserType.Organization,
                "User" => WebhookIssuesDemilestonedIssueUserType.User,
                _ => null,
            };
        }
    }
}
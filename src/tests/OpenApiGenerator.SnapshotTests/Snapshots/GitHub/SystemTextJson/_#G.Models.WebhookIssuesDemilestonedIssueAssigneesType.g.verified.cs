//HintName: G.Models.WebhookIssuesDemilestonedIssueAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesDemilestonedIssueAssigneesType
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
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesDemilestonedIssueAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssueAssigneesType value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssueAssigneesType.Bot => "Bot",
                WebhookIssuesDemilestonedIssueAssigneesType.User => "User",
                WebhookIssuesDemilestonedIssueAssigneesType.Organization => "Organization",
                WebhookIssuesDemilestonedIssueAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssueAssigneesType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDemilestonedIssueAssigneesType.Bot,
                "User" => WebhookIssuesDemilestonedIssueAssigneesType.User,
                "Organization" => WebhookIssuesDemilestonedIssueAssigneesType.Organization,
                "Mannequin" => WebhookIssuesDemilestonedIssueAssigneesType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
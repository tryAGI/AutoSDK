//HintName: G.Models.WebhookIssuesDemilestonedIssueUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesDemilestonedIssueUserType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
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
//HintName: G.Models.WebhookIssuesDemilestonedIssueAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesDemilestonedIssueAssigneeType
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
    public static class WebhookIssuesDemilestonedIssueAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssueAssigneeType value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssueAssigneeType.Bot => "Bot",
                WebhookIssuesDemilestonedIssueAssigneeType.Mannequin => "Mannequin",
                WebhookIssuesDemilestonedIssueAssigneeType.Organization => "Organization",
                WebhookIssuesDemilestonedIssueAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssueAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDemilestonedIssueAssigneeType.Bot,
                "Mannequin" => WebhookIssuesDemilestonedIssueAssigneeType.Mannequin,
                "Organization" => WebhookIssuesDemilestonedIssueAssigneeType.Organization,
                "User" => WebhookIssuesDemilestonedIssueAssigneeType.User,
                _ => null,
            };
        }
    }
}
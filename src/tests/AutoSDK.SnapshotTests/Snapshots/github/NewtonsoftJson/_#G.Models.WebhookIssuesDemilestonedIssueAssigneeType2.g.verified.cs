//HintName: G.Models.WebhookIssuesDemilestonedIssueAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesDemilestonedIssueAssigneeType2
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
    public static class WebhookIssuesDemilestonedIssueAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssueAssigneeType2 value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssueAssigneeType2.Bot => "Bot",
                WebhookIssuesDemilestonedIssueAssigneeType2.Mannequin => "Mannequin",
                WebhookIssuesDemilestonedIssueAssigneeType2.Organization => "Organization",
                WebhookIssuesDemilestonedIssueAssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssueAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDemilestonedIssueAssigneeType2.Bot,
                "Mannequin" => WebhookIssuesDemilestonedIssueAssigneeType2.Mannequin,
                "Organization" => WebhookIssuesDemilestonedIssueAssigneeType2.Organization,
                "User" => WebhookIssuesDemilestonedIssueAssigneeType2.User,
                _ => null,
            };
        }
    }
}
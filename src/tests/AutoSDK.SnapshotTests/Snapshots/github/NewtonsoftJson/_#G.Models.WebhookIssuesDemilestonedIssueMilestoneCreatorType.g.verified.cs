//HintName: G.Models.WebhookIssuesDemilestonedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesDemilestonedIssueMilestoneCreatorType
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
    public static class WebhookIssuesDemilestonedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesDemilestonedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookIssuesDemilestonedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesDemilestonedIssueMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesDemilestonedIssueMilestoneCreatorType.Bot,
                "Mannequin" => WebhookIssuesDemilestonedIssueMilestoneCreatorType.Mannequin,
                "Organization" => WebhookIssuesDemilestonedIssueMilestoneCreatorType.Organization,
                "User" => WebhookIssuesDemilestonedIssueMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}
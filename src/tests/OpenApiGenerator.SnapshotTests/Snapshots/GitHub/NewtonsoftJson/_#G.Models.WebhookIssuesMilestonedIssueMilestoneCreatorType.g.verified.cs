//HintName: G.Models.WebhookIssuesMilestonedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesMilestonedIssueMilestoneCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesMilestonedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesMilestonedIssueMilestoneCreatorType.User => "User",
                WebhookIssuesMilestonedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesMilestonedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssueMilestoneCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesMilestonedIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssuesMilestonedIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssuesMilestonedIssueMilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssuesMilestonedIssueMilestoneCreatorType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
//HintName: G.Models.WebhookIssuesOpenedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesOpenedIssueMilestoneCreatorType
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
    public static class WebhookIssuesOpenedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesOpenedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookIssuesOpenedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesOpenedIssueMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesOpenedIssueMilestoneCreatorType.Bot,
                "Mannequin" => WebhookIssuesOpenedIssueMilestoneCreatorType.Mannequin,
                "Organization" => WebhookIssuesOpenedIssueMilestoneCreatorType.Organization,
                "User" => WebhookIssuesOpenedIssueMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}
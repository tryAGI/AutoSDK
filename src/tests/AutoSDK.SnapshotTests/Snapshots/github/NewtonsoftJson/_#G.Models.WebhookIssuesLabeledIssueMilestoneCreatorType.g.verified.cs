//HintName: G.Models.WebhookIssuesLabeledIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesLabeledIssueMilestoneCreatorType
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
    public static class WebhookIssuesLabeledIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesLabeledIssueMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookIssuesLabeledIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesLabeledIssueMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesLabeledIssueMilestoneCreatorType.Bot,
                "Mannequin" => WebhookIssuesLabeledIssueMilestoneCreatorType.Mannequin,
                "Organization" => WebhookIssuesLabeledIssueMilestoneCreatorType.Organization,
                "User" => WebhookIssuesLabeledIssueMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}
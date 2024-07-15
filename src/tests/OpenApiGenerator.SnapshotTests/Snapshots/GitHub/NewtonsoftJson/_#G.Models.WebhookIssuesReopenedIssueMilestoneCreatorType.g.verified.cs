//HintName: G.Models.WebhookIssuesReopenedIssueMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesReopenedIssueMilestoneCreatorType
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
    public static class WebhookIssuesReopenedIssueMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssueMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssueMilestoneCreatorType.Bot => "Bot",
                WebhookIssuesReopenedIssueMilestoneCreatorType.User => "User",
                WebhookIssuesReopenedIssueMilestoneCreatorType.Organization => "Organization",
                WebhookIssuesReopenedIssueMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssueMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesReopenedIssueMilestoneCreatorType.Bot,
                "User" => WebhookIssuesReopenedIssueMilestoneCreatorType.User,
                "Organization" => WebhookIssuesReopenedIssueMilestoneCreatorType.Organization,
                "Mannequin" => WebhookIssuesReopenedIssueMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestDequeuedPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestDequeuedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.Bot,
                "Mannequin" => WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.Mannequin,
                "Organization" => WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestDequeuedPullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}
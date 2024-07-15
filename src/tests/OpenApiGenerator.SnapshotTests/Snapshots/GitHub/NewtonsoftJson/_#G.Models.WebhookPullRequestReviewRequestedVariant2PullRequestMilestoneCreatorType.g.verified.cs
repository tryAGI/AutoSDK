//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.Organization,
                "Mannequin" => WebhookPullRequestReviewRequestedVariant2PullRequestMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneCreatorType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneCreatorType.Organization,
                "Mannequin" => WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}
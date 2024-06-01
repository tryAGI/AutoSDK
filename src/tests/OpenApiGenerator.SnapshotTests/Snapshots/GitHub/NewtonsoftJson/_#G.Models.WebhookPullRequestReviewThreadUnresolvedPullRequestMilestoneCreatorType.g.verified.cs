//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneCreatorType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneCreatorType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneCreatorType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneCreatorType.Bot,
                "User" => WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneCreatorType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
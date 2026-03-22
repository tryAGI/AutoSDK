//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedPullRequestMilestoneCreatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestReviewThreadResolvedPullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedPullRequestMilestoneCreatorType.Bot,
                "Organization" => WebhookPullRequestReviewThreadResolvedPullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestReviewThreadResolvedPullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}
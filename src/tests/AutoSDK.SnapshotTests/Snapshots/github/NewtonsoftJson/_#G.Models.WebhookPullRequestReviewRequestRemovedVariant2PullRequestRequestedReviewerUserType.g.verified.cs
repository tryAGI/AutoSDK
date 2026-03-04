//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerUserType.Bot,
                "User" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestRequestedReviewerUserType.Organization,
                _ => null,
            };
        }
    }
}
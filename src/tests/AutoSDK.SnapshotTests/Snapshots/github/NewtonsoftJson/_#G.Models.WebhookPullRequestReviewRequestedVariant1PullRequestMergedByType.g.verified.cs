//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType.Bot,
                "Organization" => WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType.Organization,
                "User" => WebhookPullRequestReviewRequestedVariant1PullRequestMergedByType.User,
                _ => null,
            };
        }
    }
}
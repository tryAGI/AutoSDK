//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoOwnerType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}
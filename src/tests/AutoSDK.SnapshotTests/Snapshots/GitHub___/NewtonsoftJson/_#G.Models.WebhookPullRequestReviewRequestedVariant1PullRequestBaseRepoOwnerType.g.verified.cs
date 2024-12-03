//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoOwnerType.User => "User",
                WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoOwnerType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoOwnerType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant1PullRequestBaseRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType.User => "User",
                WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType.Bot,
                "User" => WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType.User,
                "Organization" => WebhookPullRequestReviewThreadResolvedPullRequestHeadRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}
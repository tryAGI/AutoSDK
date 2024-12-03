//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoOwnerType.User => "User",
                WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoOwnerType.Bot,
                "User" => WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoOwnerType.User,
                "Organization" => WebhookPullRequestReviewThreadUnresolvedPullRequestBaseRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}
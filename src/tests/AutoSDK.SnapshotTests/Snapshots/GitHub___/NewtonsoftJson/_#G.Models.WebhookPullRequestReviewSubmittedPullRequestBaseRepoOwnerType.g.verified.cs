//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType
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
    public static class WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType.User => "User",
                WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType.Bot,
                "User" => WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType.User,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestBaseRepoOwnerType.Organization,
                _ => null,
            };
        }
    }
}
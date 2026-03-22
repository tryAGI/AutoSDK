//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType.Bot,
                "Organization" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType.Organization,
                "User" => WebhookPullRequestReviewRequestedVariant1PullRequestHeadUserType.User,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestBaseUserType
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant2PullRequestBaseUserType.User => "User",
                WebhookPullRequestReviewRequestedVariant2PullRequestBaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant2PullRequestBaseUserType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant2PullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant2PullRequestBaseUserType.Organization,
                _ => null,
            };
        }
    }
}
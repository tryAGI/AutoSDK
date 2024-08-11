//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant2PullRequestRequestedReviewerVariant1Type.Organization,
                _ => null,
            };
        }
    }
}
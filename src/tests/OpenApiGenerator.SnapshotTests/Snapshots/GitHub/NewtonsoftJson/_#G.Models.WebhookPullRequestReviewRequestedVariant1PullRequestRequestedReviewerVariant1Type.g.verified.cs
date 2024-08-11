//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant1PullRequestRequestedReviewerVariant1Type.Organization,
                _ => null,
            };
        }
    }
}
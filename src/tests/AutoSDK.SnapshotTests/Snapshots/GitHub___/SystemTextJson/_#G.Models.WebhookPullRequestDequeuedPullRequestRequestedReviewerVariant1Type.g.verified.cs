//HintName: G.Models.WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestDequeuedPullRequestRequestedReviewerVariant1Type.Organization,
                _ => null,
            };
        }
    }
}
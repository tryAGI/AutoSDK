//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant2ParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant2ParentPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Secret,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant2ParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant2ParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant2ParentPrivacy.Open => "open",
                WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant2ParentPrivacy.Closed => "closed",
                WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant2ParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant2ParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant2ParentPrivacy.Open,
                "closed" => WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant2ParentPrivacy.Closed,
                "secret" => WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant2ParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}
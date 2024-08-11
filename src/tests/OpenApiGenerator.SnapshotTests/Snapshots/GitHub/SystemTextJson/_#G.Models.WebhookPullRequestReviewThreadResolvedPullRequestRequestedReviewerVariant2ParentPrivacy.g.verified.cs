//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant2ParentPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant2ParentPrivacy
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant2ParentPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant2ParentPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant2ParentPrivacy.Open => "open",
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant2ParentPrivacy.Closed => "closed",
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant2ParentPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant2ParentPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant2ParentPrivacy.Open,
                "closed" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant2ParentPrivacy.Closed,
                "secret" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant2ParentPrivacy.Secret,
                _ => null,
            };
        }
    }
}
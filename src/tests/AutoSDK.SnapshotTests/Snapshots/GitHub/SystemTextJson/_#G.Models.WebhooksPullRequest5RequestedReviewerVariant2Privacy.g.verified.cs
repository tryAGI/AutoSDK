//HintName: G.Models.WebhooksPullRequest5RequestedReviewerVariant2Privacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPullRequest5RequestedReviewerVariant2Privacy
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
    public static class WebhooksPullRequest5RequestedReviewerVariant2PrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5RequestedReviewerVariant2Privacy value)
        {
            return value switch
            {
                WebhooksPullRequest5RequestedReviewerVariant2Privacy.Open => "open",
                WebhooksPullRequest5RequestedReviewerVariant2Privacy.Closed => "closed",
                WebhooksPullRequest5RequestedReviewerVariant2Privacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5RequestedReviewerVariant2Privacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhooksPullRequest5RequestedReviewerVariant2Privacy.Open,
                "closed" => WebhooksPullRequest5RequestedReviewerVariant2Privacy.Closed,
                "secret" => WebhooksPullRequest5RequestedReviewerVariant2Privacy.Secret,
                _ => null,
            };
        }
    }
}
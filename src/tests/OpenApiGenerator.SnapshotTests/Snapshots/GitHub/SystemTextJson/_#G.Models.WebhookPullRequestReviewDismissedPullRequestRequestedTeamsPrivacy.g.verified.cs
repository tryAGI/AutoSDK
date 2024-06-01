//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestRequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestRequestedTeamsPrivacy
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
    public static class WebhookPullRequestReviewDismissedPullRequestRequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestRequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamsPrivacy.Open => "open",
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamsPrivacy.Closed => "closed",
                WebhookPullRequestReviewDismissedPullRequestRequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestRequestedTeamsPrivacy ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamsPrivacy.Open,
                "closed" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamsPrivacy.Closed,
                "secret" => WebhookPullRequestReviewDismissedPullRequestRequestedTeamsPrivacy.Secret,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
//HintName: G.Models.WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamsPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamsPrivacy
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
    public static class WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamsPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamsPrivacy value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamsPrivacy.Open => "open",
                WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamsPrivacy.Closed => "closed",
                WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamsPrivacy.Secret => "secret",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamsPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamsPrivacy.Open,
                "closed" => WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamsPrivacy.Closed,
                "secret" => WebhookPullRequestReviewCommentEditedPullRequestRequestedTeamsPrivacy.Secret,
                _ => null,
            };
        }
    }
}
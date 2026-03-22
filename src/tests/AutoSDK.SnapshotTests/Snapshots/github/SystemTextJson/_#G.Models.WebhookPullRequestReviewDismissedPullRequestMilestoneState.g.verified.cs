//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookPullRequestReviewDismissedPullRequestMilestoneState
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewDismissedPullRequestMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestMilestoneState value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestMilestoneState.Closed => "closed",
                WebhookPullRequestReviewDismissedPullRequestMilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestReviewDismissedPullRequestMilestoneState.Closed,
                "open" => WebhookPullRequestReviewDismissedPullRequestMilestoneState.Open,
                _ => null,
            };
        }
    }
}
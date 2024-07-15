//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneState value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneState.Open => "open",
                WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneState.Open,
                "closed" => WebhookPullRequestReviewRequestRemovedVariant2PullRequestMilestoneState.Closed,
                _ => null,
            };
        }
    }
}
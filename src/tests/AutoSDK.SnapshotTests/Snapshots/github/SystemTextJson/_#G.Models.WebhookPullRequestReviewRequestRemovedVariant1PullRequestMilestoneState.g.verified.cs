//HintName: G.Models.WebhookPullRequestReviewRequestRemovedVariant1PullRequestMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookPullRequestReviewRequestRemovedVariant1PullRequestMilestoneState
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
    public static class WebhookPullRequestReviewRequestRemovedVariant1PullRequestMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestRemovedVariant1PullRequestMilestoneState value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestMilestoneState.Closed => "closed",
                WebhookPullRequestReviewRequestRemovedVariant1PullRequestMilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestRemovedVariant1PullRequestMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestMilestoneState.Closed,
                "open" => WebhookPullRequestReviewRequestRemovedVariant1PullRequestMilestoneState.Open,
                _ => null,
            };
        }
    }
}
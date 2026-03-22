//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneState
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneState value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneState.Closed => "closed",
                WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneState.Closed,
                "open" => WebhookPullRequestReviewRequestedVariant1PullRequestMilestoneState.Open,
                _ => null,
            };
        }
    }
}
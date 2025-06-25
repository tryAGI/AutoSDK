﻿//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneState
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
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneState value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneState.Open => "open",
                WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneState.Open,
                "closed" => WebhookPullRequestReviewThreadUnresolvedPullRequestMilestoneState.Closed,
                _ => null,
            };
        }
    }
}
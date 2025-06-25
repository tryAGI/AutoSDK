﻿//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledPullRequestMilestoneState
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestMilestoneState value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestMilestoneState.Open => "open",
                WebhookPullRequestAutoMergeEnabledPullRequestMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestAutoMergeEnabledPullRequestMilestoneState.Open,
                "closed" => WebhookPullRequestAutoMergeEnabledPullRequestMilestoneState.Closed,
                _ => null,
            };
        }
    }
}
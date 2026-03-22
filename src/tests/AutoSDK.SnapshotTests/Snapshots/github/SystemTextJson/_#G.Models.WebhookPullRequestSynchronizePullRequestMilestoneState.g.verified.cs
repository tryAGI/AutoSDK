//HintName: G.Models.WebhookPullRequestSynchronizePullRequestMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookPullRequestSynchronizePullRequestMilestoneState
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
    public static class WebhookPullRequestSynchronizePullRequestMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestSynchronizePullRequestMilestoneState value)
        {
            return value switch
            {
                WebhookPullRequestSynchronizePullRequestMilestoneState.Closed => "closed",
                WebhookPullRequestSynchronizePullRequestMilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestSynchronizePullRequestMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestSynchronizePullRequestMilestoneState.Closed,
                "open" => WebhookPullRequestSynchronizePullRequestMilestoneState.Open,
                _ => null,
            };
        }
    }
}
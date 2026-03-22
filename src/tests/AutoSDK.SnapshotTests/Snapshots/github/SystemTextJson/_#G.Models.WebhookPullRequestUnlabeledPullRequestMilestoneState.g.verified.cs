//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestMilestoneState
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
    public static class WebhookPullRequestUnlabeledPullRequestMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestMilestoneState value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestMilestoneState.Closed => "closed",
                WebhookPullRequestUnlabeledPullRequestMilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestUnlabeledPullRequestMilestoneState.Closed,
                "open" => WebhookPullRequestUnlabeledPullRequestMilestoneState.Open,
                _ => null,
            };
        }
    }
}
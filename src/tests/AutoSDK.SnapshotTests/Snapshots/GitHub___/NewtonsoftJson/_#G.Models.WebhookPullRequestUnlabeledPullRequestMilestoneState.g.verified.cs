//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlabeledPullRequestMilestoneState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
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
                WebhookPullRequestUnlabeledPullRequestMilestoneState.Open => "open",
                WebhookPullRequestUnlabeledPullRequestMilestoneState.Closed => "closed",
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
                "open" => WebhookPullRequestUnlabeledPullRequestMilestoneState.Open,
                "closed" => WebhookPullRequestUnlabeledPullRequestMilestoneState.Closed,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookPullRequestUnassignedPullRequestMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnassignedPullRequestMilestoneState
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
    public static class WebhookPullRequestUnassignedPullRequestMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestMilestoneState value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestMilestoneState.Open => "open",
                WebhookPullRequestUnassignedPullRequestMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestUnassignedPullRequestMilestoneState.Open,
                "closed" => WebhookPullRequestUnassignedPullRequestMilestoneState.Closed,
                _ => null,
            };
        }
    }
}
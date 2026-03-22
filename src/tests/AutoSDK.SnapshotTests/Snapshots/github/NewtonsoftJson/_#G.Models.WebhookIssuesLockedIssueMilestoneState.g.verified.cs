//HintName: G.Models.WebhookIssuesLockedIssueMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesLockedIssueMilestoneState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesLockedIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssueMilestoneState value)
        {
            return value switch
            {
                WebhookIssuesLockedIssueMilestoneState.Closed => "closed",
                WebhookIssuesLockedIssueMilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssueMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssuesLockedIssueMilestoneState.Closed,
                "open" => WebhookIssuesLockedIssueMilestoneState.Open,
                _ => null,
            };
        }
    }
}
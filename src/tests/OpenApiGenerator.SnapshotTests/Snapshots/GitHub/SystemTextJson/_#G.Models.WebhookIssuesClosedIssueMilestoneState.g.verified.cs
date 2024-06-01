//HintName: G.Models.WebhookIssuesClosedIssueMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssuesClosedIssueMilestoneState
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
    public static class WebhookIssuesClosedIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueMilestoneState value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueMilestoneState.Open => "open",
                WebhookIssuesClosedIssueMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueMilestoneState ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesClosedIssueMilestoneState.Open,
                "closed" => WebhookIssuesClosedIssueMilestoneState.Closed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
//HintName: G.Models.WebhookIssuesOpenedIssueMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssuesOpenedIssueMilestoneState
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
    public static class WebhookIssuesOpenedIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssueMilestoneState value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssueMilestoneState.Open => "open",
                WebhookIssuesOpenedIssueMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssueMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesOpenedIssueMilestoneState.Open,
                "closed" => WebhookIssuesOpenedIssueMilestoneState.Closed,
                _ => null,
            };
        }
    }
}
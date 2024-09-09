//HintName: G.Models.WebhooksIssueMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhooksIssueMilestoneState
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
    public static class WebhooksIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueMilestoneState value)
        {
            return value switch
            {
                WebhooksIssueMilestoneState.Open => "open",
                WebhooksIssueMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhooksIssueMilestoneState.Open,
                "closed" => WebhooksIssueMilestoneState.Closed,
                _ => null,
            };
        }
    }
}
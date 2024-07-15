//HintName: G.Models.WebhooksMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhooksMilestoneState
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
    public static class WebhooksMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksMilestoneState value)
        {
            return value switch
            {
                WebhooksMilestoneState.Open => "open",
                WebhooksMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhooksMilestoneState.Open,
                "closed" => WebhooksMilestoneState.Closed,
                _ => null,
            };
        }
    }
}
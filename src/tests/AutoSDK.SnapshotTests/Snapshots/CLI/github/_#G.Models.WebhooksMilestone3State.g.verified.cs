//HintName: G.Models.WebhooksMilestone3State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhooksMilestone3State
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
    public static class WebhooksMilestone3StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksMilestone3State value)
        {
            return value switch
            {
                WebhooksMilestone3State.Open => "open",
                WebhooksMilestone3State.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksMilestone3State? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhooksMilestone3State.Open,
                "closed" => WebhooksMilestone3State.Closed,
                _ => null,
            };
        }
    }
}
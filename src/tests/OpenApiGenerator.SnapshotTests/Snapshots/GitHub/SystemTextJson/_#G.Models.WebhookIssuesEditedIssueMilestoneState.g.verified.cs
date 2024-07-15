//HintName: G.Models.WebhookIssuesEditedIssueMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssuesEditedIssueMilestoneState
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
    public static class WebhookIssuesEditedIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssueMilestoneState value)
        {
            return value switch
            {
                WebhookIssuesEditedIssueMilestoneState.Open => "open",
                WebhookIssuesEditedIssueMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssueMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesEditedIssueMilestoneState.Open,
                "closed" => WebhookIssuesEditedIssueMilestoneState.Closed,
                _ => null,
            };
        }
    }
}
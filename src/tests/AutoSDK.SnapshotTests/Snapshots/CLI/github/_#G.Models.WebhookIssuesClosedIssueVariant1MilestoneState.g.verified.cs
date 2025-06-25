//HintName: G.Models.WebhookIssuesClosedIssueVariant1MilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssuesClosedIssueVariant1MilestoneState
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
    public static class WebhookIssuesClosedIssueVariant1MilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant1MilestoneState value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant1MilestoneState.Open => "open",
                WebhookIssuesClosedIssueVariant1MilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant1MilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesClosedIssueVariant1MilestoneState.Open,
                "closed" => WebhookIssuesClosedIssueVariant1MilestoneState.Closed,
                _ => null,
            };
        }
    }
}
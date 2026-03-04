//HintName: G.Models.WebhookIssuesClosedIssueIssue1MilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssuesClosedIssueIssue1MilestoneState
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
    public static class WebhookIssuesClosedIssueIssue1MilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueIssue1MilestoneState value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueIssue1MilestoneState.Open => "open",
                WebhookIssuesClosedIssueIssue1MilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueIssue1MilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesClosedIssueIssue1MilestoneState.Open,
                "closed" => WebhookIssuesClosedIssueIssue1MilestoneState.Closed,
                _ => null,
            };
        }
    }
}
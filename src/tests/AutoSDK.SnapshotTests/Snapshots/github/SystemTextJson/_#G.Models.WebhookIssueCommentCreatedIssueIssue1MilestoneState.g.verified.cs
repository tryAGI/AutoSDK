//HintName: G.Models.WebhookIssueCommentCreatedIssueIssue1MilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueIssue1MilestoneState
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentCreatedIssueIssue1MilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueIssue1MilestoneState value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueIssue1MilestoneState.Closed => "closed",
                WebhookIssueCommentCreatedIssueIssue1MilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueIssue1MilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssueCommentCreatedIssueIssue1MilestoneState.Closed,
                "open" => WebhookIssueCommentCreatedIssueIssue1MilestoneState.Open,
                _ => null,
            };
        }
    }
}
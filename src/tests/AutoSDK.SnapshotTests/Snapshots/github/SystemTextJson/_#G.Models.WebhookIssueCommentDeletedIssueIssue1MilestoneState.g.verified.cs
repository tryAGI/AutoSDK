//HintName: G.Models.WebhookIssueCommentDeletedIssueIssue1MilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueIssue1MilestoneState
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
    public static class WebhookIssueCommentDeletedIssueIssue1MilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueIssue1MilestoneState value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueIssue1MilestoneState.Open => "open",
                WebhookIssueCommentDeletedIssueIssue1MilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueIssue1MilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssueCommentDeletedIssueIssue1MilestoneState.Open,
                "closed" => WebhookIssueCommentDeletedIssueIssue1MilestoneState.Closed,
                _ => null,
            };
        }
    }
}
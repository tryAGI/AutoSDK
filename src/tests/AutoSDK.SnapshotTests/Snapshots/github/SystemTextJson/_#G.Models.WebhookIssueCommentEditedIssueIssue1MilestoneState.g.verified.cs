//HintName: G.Models.WebhookIssueCommentEditedIssueIssue1MilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssueCommentEditedIssueIssue1MilestoneState
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
    public static class WebhookIssueCommentEditedIssueIssue1MilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueIssue1MilestoneState value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueIssue1MilestoneState.Closed => "closed",
                WebhookIssueCommentEditedIssueIssue1MilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueIssue1MilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssueCommentEditedIssueIssue1MilestoneState.Closed,
                "open" => WebhookIssueCommentEditedIssueIssue1MilestoneState.Open,
                _ => null,
            };
        }
    }
}
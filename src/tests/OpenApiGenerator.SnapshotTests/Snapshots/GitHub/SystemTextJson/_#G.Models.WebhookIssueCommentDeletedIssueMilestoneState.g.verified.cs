//HintName: G.Models.WebhookIssueCommentDeletedIssueMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueMilestoneState
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
    public static class WebhookIssueCommentDeletedIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueMilestoneState value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueMilestoneState.Open => "open",
                WebhookIssueCommentDeletedIssueMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssueCommentDeletedIssueMilestoneState.Open,
                "closed" => WebhookIssueCommentDeletedIssueMilestoneState.Closed,
                _ => null,
            };
        }
    }
}
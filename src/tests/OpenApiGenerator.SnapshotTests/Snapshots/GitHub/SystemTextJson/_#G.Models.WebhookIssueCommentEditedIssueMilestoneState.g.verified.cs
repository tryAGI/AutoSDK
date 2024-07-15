//HintName: G.Models.WebhookIssueCommentEditedIssueMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssueCommentEditedIssueMilestoneState
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
    public static class WebhookIssueCommentEditedIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueMilestoneState value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueMilestoneState.Open => "open",
                WebhookIssueCommentEditedIssueMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssueCommentEditedIssueMilestoneState.Open,
                "closed" => WebhookIssueCommentEditedIssueMilestoneState.Closed,
                _ => null,
            };
        }
    }
}
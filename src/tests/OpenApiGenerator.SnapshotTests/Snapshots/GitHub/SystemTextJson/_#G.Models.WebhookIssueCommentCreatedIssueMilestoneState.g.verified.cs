//HintName: G.Models.WebhookIssueCommentCreatedIssueMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueMilestoneState
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
    public static class WebhookIssueCommentCreatedIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueMilestoneState value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueMilestoneState.Open => "open",
                WebhookIssueCommentCreatedIssueMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssueCommentCreatedIssueMilestoneState.Open,
                "closed" => WebhookIssueCommentCreatedIssueMilestoneState.Closed,
                _ => null,
            };
        }
    }
}
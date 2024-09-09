//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1MilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueVariant1MilestoneState
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
    public static class WebhookIssueCommentDeletedIssueVariant1MilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1MilestoneState value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1MilestoneState.Open => "open",
                WebhookIssueCommentDeletedIssueVariant1MilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1MilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssueCommentDeletedIssueVariant1MilestoneState.Open,
                "closed" => WebhookIssueCommentDeletedIssueVariant1MilestoneState.Closed,
                _ => null,
            };
        }
    }
}
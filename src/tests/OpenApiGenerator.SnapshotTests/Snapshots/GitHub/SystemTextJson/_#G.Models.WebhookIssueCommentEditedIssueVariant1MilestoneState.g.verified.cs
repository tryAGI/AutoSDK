//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1MilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssueCommentEditedIssueVariant1MilestoneState
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
    public static class WebhookIssueCommentEditedIssueVariant1MilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1MilestoneState value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1MilestoneState.Open => "open",
                WebhookIssueCommentEditedIssueVariant1MilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1MilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssueCommentEditedIssueVariant1MilestoneState.Open,
                "closed" => WebhookIssueCommentEditedIssueVariant1MilestoneState.Closed,
                _ => null,
            };
        }
    }
}
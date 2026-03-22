//HintName: G.Models.WebhookIssueCommentEditedIssueIssue1State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssueCommentEditedIssueIssue1State
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
    public static class WebhookIssueCommentEditedIssueIssue1StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueIssue1State value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueIssue1State.Closed => "closed",
                WebhookIssueCommentEditedIssueIssue1State.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueIssue1State? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssueCommentEditedIssueIssue1State.Closed,
                "open" => WebhookIssueCommentEditedIssueIssue1State.Open,
                _ => null,
            };
        }
    }
}
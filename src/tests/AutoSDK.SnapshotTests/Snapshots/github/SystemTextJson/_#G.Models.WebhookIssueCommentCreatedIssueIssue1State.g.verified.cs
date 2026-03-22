//HintName: G.Models.WebhookIssueCommentCreatedIssueIssue1State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueIssue1State
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
    public static class WebhookIssueCommentCreatedIssueIssue1StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueIssue1State value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueIssue1State.Closed => "closed",
                WebhookIssueCommentCreatedIssueIssue1State.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueIssue1State? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssueCommentCreatedIssueIssue1State.Closed,
                "open" => WebhookIssueCommentCreatedIssueIssue1State.Open,
                _ => null,
            };
        }
    }
}
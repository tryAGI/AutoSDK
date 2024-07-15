//HintName: G.Models.WebhookIssueCommentEditedIssueState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssueCommentEditedIssueState
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
    public static class WebhookIssueCommentEditedIssueStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueState value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueState.Open => "open",
                WebhookIssueCommentEditedIssueState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssueCommentEditedIssueState.Open,
                "closed" => WebhookIssueCommentEditedIssueState.Closed,
                _ => null,
            };
        }
    }
}
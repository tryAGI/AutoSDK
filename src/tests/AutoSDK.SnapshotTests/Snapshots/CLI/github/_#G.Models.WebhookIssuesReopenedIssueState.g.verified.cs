//HintName: G.Models.WebhookIssuesReopenedIssueState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssuesReopenedIssueState
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
    public static class WebhookIssuesReopenedIssueStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssueState value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssueState.Open => "open",
                WebhookIssuesReopenedIssueState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssueState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesReopenedIssueState.Open,
                "closed" => WebhookIssuesReopenedIssueState.Closed,
                _ => null,
            };
        }
    }
}
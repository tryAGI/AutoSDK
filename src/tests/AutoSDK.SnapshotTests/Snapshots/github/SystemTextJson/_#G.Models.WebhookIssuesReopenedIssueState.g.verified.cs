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
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
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
                WebhookIssuesReopenedIssueState.Closed => "closed",
                WebhookIssuesReopenedIssueState.Open => "open",
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
                "closed" => WebhookIssuesReopenedIssueState.Closed,
                "open" => WebhookIssuesReopenedIssueState.Open,
                _ => null,
            };
        }
    }
}
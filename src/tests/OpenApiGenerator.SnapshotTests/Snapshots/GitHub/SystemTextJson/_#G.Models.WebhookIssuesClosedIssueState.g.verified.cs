//HintName: G.Models.WebhookIssuesClosedIssueState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssuesClosedIssueState
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
    public static class WebhookIssuesClosedIssueStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueState value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueState.Open => "open",
                WebhookIssuesClosedIssueState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesClosedIssueState.Open,
                "closed" => WebhookIssuesClosedIssueState.Closed,
                _ => null,
            };
        }
    }
}
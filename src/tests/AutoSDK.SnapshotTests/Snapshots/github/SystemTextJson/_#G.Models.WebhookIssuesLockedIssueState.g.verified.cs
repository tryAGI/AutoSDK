//HintName: G.Models.WebhookIssuesLockedIssueState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssuesLockedIssueState
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
    public static class WebhookIssuesLockedIssueStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLockedIssueState value)
        {
            return value switch
            {
                WebhookIssuesLockedIssueState.Closed => "closed",
                WebhookIssuesLockedIssueState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLockedIssueState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssuesLockedIssueState.Closed,
                "open" => WebhookIssuesLockedIssueState.Open,
                _ => null,
            };
        }
    }
}
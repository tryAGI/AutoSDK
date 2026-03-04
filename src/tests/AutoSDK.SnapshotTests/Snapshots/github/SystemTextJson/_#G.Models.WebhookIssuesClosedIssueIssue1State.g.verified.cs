//HintName: G.Models.WebhookIssuesClosedIssueIssue1State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssuesClosedIssueIssue1State
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
    public static class WebhookIssuesClosedIssueIssue1StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueIssue1State value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueIssue1State.Open => "open",
                WebhookIssuesClosedIssueIssue1State.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueIssue1State? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesClosedIssueIssue1State.Open,
                "closed" => WebhookIssuesClosedIssueIssue1State.Closed,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookIssuesUnlockedIssueState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssuesUnlockedIssueState
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
    public static class WebhookIssuesUnlockedIssueStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssueState value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssueState.Open => "open",
                WebhookIssuesUnlockedIssueState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssueState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesUnlockedIssueState.Open,
                "closed" => WebhookIssuesUnlockedIssueState.Closed,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookIssuesTransferredChangesNewIssueState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewIssueState
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
    public static class WebhookIssuesTransferredChangesNewIssueStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssueState value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssueState.Open => "open",
                WebhookIssuesTransferredChangesNewIssueState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssueState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesTransferredChangesNewIssueState.Open,
                "closed" => WebhookIssuesTransferredChangesNewIssueState.Closed,
                _ => null,
            };
        }
    }
}
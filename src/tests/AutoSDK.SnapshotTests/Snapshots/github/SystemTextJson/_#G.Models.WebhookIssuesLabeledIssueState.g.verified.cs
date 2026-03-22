//HintName: G.Models.WebhookIssuesLabeledIssueState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssuesLabeledIssueState
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
    public static class WebhookIssuesLabeledIssueStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssueState value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssueState.Closed => "closed",
                WebhookIssuesLabeledIssueState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssueState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssuesLabeledIssueState.Closed,
                "open" => WebhookIssuesLabeledIssueState.Open,
                _ => null,
            };
        }
    }
}
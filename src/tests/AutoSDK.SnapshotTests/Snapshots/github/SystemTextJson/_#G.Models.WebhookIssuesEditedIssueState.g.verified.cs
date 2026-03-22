//HintName: G.Models.WebhookIssuesEditedIssueState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssuesEditedIssueState
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
    public static class WebhookIssuesEditedIssueStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssueState value)
        {
            return value switch
            {
                WebhookIssuesEditedIssueState.Closed => "closed",
                WebhookIssuesEditedIssueState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssueState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssuesEditedIssueState.Closed,
                "open" => WebhookIssuesEditedIssueState.Open,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookIssuesMilestonedIssueState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssuesMilestonedIssueState
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
    public static class WebhookIssuesMilestonedIssueStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssueState value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssueState.Closed => "closed",
                WebhookIssuesMilestonedIssueState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssueState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssuesMilestonedIssueState.Closed,
                "open" => WebhookIssuesMilestonedIssueState.Open,
                _ => null,
            };
        }
    }
}
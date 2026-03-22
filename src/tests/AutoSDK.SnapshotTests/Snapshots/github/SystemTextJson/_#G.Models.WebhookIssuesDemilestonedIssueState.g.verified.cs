//HintName: G.Models.WebhookIssuesDemilestonedIssueState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssuesDemilestonedIssueState
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
    public static class WebhookIssuesDemilestonedIssueStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssueState value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssueState.Closed => "closed",
                WebhookIssuesDemilestonedIssueState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssueState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssuesDemilestonedIssueState.Closed,
                "open" => WebhookIssuesDemilestonedIssueState.Open,
                _ => null,
            };
        }
    }
}
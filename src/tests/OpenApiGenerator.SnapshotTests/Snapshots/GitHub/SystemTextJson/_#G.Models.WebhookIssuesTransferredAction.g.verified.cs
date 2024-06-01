//HintName: G.Models.WebhookIssuesTransferredAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesTransferredAction
    {
        /// <summary>
        /// 
        /// </summary>
        Transferred,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesTransferredActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredAction value)
        {
            return value switch
            {
                WebhookIssuesTransferredAction.Transferred => "transferred",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredAction ToEnum(string value)
        {
            return value switch
            {
                "transferred" => WebhookIssuesTransferredAction.Transferred,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
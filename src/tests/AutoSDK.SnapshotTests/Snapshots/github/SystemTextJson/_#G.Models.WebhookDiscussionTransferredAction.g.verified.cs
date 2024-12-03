//HintName: G.Models.WebhookDiscussionTransferredAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookDiscussionTransferredAction
    {
        /// <summary>
        /// 
        /// </summary>
        Transferred,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDiscussionTransferredActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDiscussionTransferredAction value)
        {
            return value switch
            {
                WebhookDiscussionTransferredAction.Transferred => "transferred",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDiscussionTransferredAction? ToEnum(string value)
        {
            return value switch
            {
                "transferred" => WebhookDiscussionTransferredAction.Transferred,
                _ => null,
            };
        }
    }
}
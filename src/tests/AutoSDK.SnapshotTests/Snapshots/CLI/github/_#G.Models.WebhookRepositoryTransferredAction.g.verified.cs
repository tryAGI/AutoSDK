//HintName: G.Models.WebhookRepositoryTransferredAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookRepositoryTransferredAction
    {
        /// <summary>
        /// 
        /// </summary>
        Transferred,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRepositoryTransferredActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRepositoryTransferredAction value)
        {
            return value switch
            {
                WebhookRepositoryTransferredAction.Transferred => "transferred",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRepositoryTransferredAction? ToEnum(string value)
        {
            return value switch
            {
                "transferred" => WebhookRepositoryTransferredAction.Transferred,
                _ => null,
            };
        }
    }
}
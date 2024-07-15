//HintName: G.Models.WebhookMarketplacePurchasePendingChangeAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMarketplacePurchasePendingChangeAction
    {
        /// <summary>
        /// 
        /// </summary>
        PendingChange,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMarketplacePurchasePendingChangeActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMarketplacePurchasePendingChangeAction value)
        {
            return value switch
            {
                WebhookMarketplacePurchasePendingChangeAction.PendingChange => "pending_change",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMarketplacePurchasePendingChangeAction? ToEnum(string value)
        {
            return value switch
            {
                "pending_change" => WebhookMarketplacePurchasePendingChangeAction.PendingChange,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhookMarketplacePurchaseCancelledAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMarketplacePurchaseCancelledAction
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMarketplacePurchaseCancelledActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMarketplacePurchaseCancelledAction value)
        {
            return value switch
            {
                WebhookMarketplacePurchaseCancelledAction.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMarketplacePurchaseCancelledAction? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => WebhookMarketplacePurchaseCancelledAction.Cancelled,
                _ => null,
            };
        }
    }
}
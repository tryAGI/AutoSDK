//HintName: G.Models.WebhookMarketplacePurchaseChangedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMarketplacePurchaseChangedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Changed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMarketplacePurchaseChangedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMarketplacePurchaseChangedAction value)
        {
            return value switch
            {
                WebhookMarketplacePurchaseChangedAction.Changed => "changed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMarketplacePurchaseChangedAction ToEnum(string value)
        {
            return value switch
            {
                "changed" => WebhookMarketplacePurchaseChangedAction.Changed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
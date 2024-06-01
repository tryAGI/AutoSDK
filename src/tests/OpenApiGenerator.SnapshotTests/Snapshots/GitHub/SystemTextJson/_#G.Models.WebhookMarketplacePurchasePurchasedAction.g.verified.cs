//HintName: G.Models.WebhookMarketplacePurchasePurchasedAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMarketplacePurchasePurchasedAction
    {
        /// <summary>
        /// 
        /// </summary>
        Purchased,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMarketplacePurchasePurchasedActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMarketplacePurchasePurchasedAction value)
        {
            return value switch
            {
                WebhookMarketplacePurchasePurchasedAction.Purchased => "purchased",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMarketplacePurchasePurchasedAction ToEnum(string value)
        {
            return value switch
            {
                "purchased" => WebhookMarketplacePurchasePurchasedAction.Purchased,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
//HintName: G.Models.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel
    {
        /// <summary>
        /// 
        /// </summary>
        FREE,
        /// <summary>
        /// 
        /// </summary>
        FLATRATE,
        /// <summary>
        /// 
        /// </summary>
        PERUNIT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel value)
        {
            return value switch
            {
                WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.FREE => "FREE",
                WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.FLATRATE => "FLAT_RATE",
                WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.PERUNIT => "PER_UNIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel ToEnum(string value)
        {
            return value switch
            {
                "FREE" => WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.FREE,
                "FLAT_RATE" => WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.FLATRATE,
                "PER_UNIT" => WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.PERUNIT,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}
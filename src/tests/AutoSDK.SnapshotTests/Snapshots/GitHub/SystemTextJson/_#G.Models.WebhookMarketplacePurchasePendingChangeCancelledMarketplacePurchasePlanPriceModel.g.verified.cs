//HintName: G.Models.WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel
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
    public static class WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel value)
        {
            return value switch
            {
                WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.FREE => "FREE",
                WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.FLATRATE => "FLAT_RATE",
                WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.PERUNIT => "PER_UNIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel? ToEnum(string value)
        {
            return value switch
            {
                "FREE" => WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.FREE,
                "FLAT_RATE" => WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.FLATRATE,
                "PER_UNIT" => WebhookMarketplacePurchasePendingChangeCancelledMarketplacePurchasePlanPriceModel.PERUNIT,
                _ => null,
            };
        }
    }
}
//HintName: G.Models.WebhooksPreviousMarketplacePurchasePlanPriceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksPreviousMarketplacePurchasePlanPriceModel
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
    public static class WebhooksPreviousMarketplacePurchasePlanPriceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPreviousMarketplacePurchasePlanPriceModel value)
        {
            return value switch
            {
                WebhooksPreviousMarketplacePurchasePlanPriceModel.FREE => "FREE",
                WebhooksPreviousMarketplacePurchasePlanPriceModel.FLATRATE => "FLAT_RATE",
                WebhooksPreviousMarketplacePurchasePlanPriceModel.PERUNIT => "PER_UNIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPreviousMarketplacePurchasePlanPriceModel? ToEnum(string value)
        {
            return value switch
            {
                "FREE" => WebhooksPreviousMarketplacePurchasePlanPriceModel.FREE,
                "FLAT_RATE" => WebhooksPreviousMarketplacePurchasePlanPriceModel.FLATRATE,
                "PER_UNIT" => WebhooksPreviousMarketplacePurchasePlanPriceModel.PERUNIT,
                _ => null,
            };
        }
    }
}
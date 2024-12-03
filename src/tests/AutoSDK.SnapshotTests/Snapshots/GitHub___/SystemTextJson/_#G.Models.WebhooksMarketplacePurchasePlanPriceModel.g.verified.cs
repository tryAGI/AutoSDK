//HintName: G.Models.WebhooksMarketplacePurchasePlanPriceModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksMarketplacePurchasePlanPriceModel
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
    public static class WebhooksMarketplacePurchasePlanPriceModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksMarketplacePurchasePlanPriceModel value)
        {
            return value switch
            {
                WebhooksMarketplacePurchasePlanPriceModel.FREE => "FREE",
                WebhooksMarketplacePurchasePlanPriceModel.FLATRATE => "FLAT_RATE",
                WebhooksMarketplacePurchasePlanPriceModel.PERUNIT => "PER_UNIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksMarketplacePurchasePlanPriceModel? ToEnum(string value)
        {
            return value switch
            {
                "FREE" => WebhooksMarketplacePurchasePlanPriceModel.FREE,
                "FLAT_RATE" => WebhooksMarketplacePurchasePlanPriceModel.FLATRATE,
                "PER_UNIT" => WebhooksMarketplacePurchasePlanPriceModel.PERUNIT,
                _ => null,
            };
        }
    }
}
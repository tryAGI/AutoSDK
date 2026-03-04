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
        Free,
        /// <summary>
        /// 
        /// </summary>
        FlatRate,
        /// <summary>
        /// 
        /// </summary>
        PerUnit,
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
                WebhooksMarketplacePurchasePlanPriceModel.Free => "FREE",
                WebhooksMarketplacePurchasePlanPriceModel.FlatRate => "FLAT_RATE",
                WebhooksMarketplacePurchasePlanPriceModel.PerUnit => "PER_UNIT",
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
                "FREE" => WebhooksMarketplacePurchasePlanPriceModel.Free,
                "FLAT_RATE" => WebhooksMarketplacePurchasePlanPriceModel.FlatRate,
                "PER_UNIT" => WebhooksMarketplacePurchasePlanPriceModel.PerUnit,
                _ => null,
            };
        }
    }
}
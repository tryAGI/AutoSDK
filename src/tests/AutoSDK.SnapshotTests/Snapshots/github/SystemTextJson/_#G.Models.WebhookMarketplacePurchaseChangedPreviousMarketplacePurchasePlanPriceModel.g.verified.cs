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
        FlatRate,
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        PerUnit,
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
                WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.FlatRate => "FLAT_RATE",
                WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.Free => "FREE",
                WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.PerUnit => "PER_UNIT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel? ToEnum(string value)
        {
            return value switch
            {
                "FLAT_RATE" => WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.FlatRate,
                "FREE" => WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.Free,
                "PER_UNIT" => WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel.PerUnit,
                _ => null,
            };
        }
    }
}